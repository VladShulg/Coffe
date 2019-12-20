using CoffeXO.Contexts;
using CoffeXO.Models;
using CoffeXO.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoffeXO.Controllers
{
    public class AccountController : Controller
    {
        private EventContext db;
        public AccountController(EventContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult LogInAsAdmin()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsAdmin(LoginModel model)
        {
            var curUser = User;

            if (curUser.Identity.IsAuthenticated)
            {
                return RedirectToAction("Admin", "Home");
            }
            //проверка модели на валидность
            if (ModelState.IsValid)
            {
                //достали из базы userа первого подходящего под параметры из модели
                Admin user = await db.Admin.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                //если такой пользователь нашелся, то происходить аунтефикация и редирект по указанному адресу
                if (user != null)
                {
                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Admin", "Home");
                }
                //если пользователь не найден, то в состояние модели добавляется ошибка
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            //если модель не валидна возвращаетс вьюха с определенной моделью
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Admin user = await db.Admin.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    db.Admin.Add(new Admin { Email = model.Email, Password = model.Password });
                    await db.SaveChangesAsync();

                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Пользователь уже зарегестрирован");
            }
            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Main", "Home");
        }
    }
}
