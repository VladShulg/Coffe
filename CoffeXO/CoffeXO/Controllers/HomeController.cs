using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeXO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using CoffeXO.Contexts;

namespace CoffeXO.Controllers
{
    public class HomeController : Controller
    {
        
        private EventContext db;
        public HomeController(EventContext context)
        {
            db = context;
        }

        [HttpPost]
        public async Task<bool> DeleteEventApi([FromForm]Event e)
        {
            if (e == null)
            {
                return false;
            }
            db.Events.Remove(await db.Events.FirstOrDefaultAsync(x => x.Id == e.Id));
            await db.SaveChangesAsync();
            return true;
        }

        [HttpPost]
        public async Task<bool> EditEventApi([FromForm]Event e)
        {
            var req = Request;

            var e2 =  await db.Events.FirstOrDefaultAsync(x => x.Id == e.Id);
            if (e2 == null)
            {
                return false;
            }
            e2.Name = e.Name;
            e2.ImgSrc = e.ImgSrc;
            e2.Info = e.Info;
            e2.Time = e.Time;
            e2.Day = e.Day;
            await db.SaveChangesAsync();
            return true;
        }
        public async Task<IActionResult> EditEvent(string id)
        {
            return View(await db.Events.FirstOrDefaultAsync(x => x.Id == id));
        }

        [HttpPost]
        public async Task<bool> AddEventApi([FromForm]Event e)
        {
            e.Id = Guid.NewGuid().ToString();
            db.Events.Add(e);
            await db.SaveChangesAsync();
            return true;
        }

        public IActionResult AddEvent()
        {
            return View();
        }

        public async Task<IActionResult> Admin()
        {
            return View(await db.Events.ToListAsync());
        }
        public IActionResult LogInAsAdmin()
        {
            AdminData admin = new AdminData { Email = "coffexo@gmail.com", Password = "rootpasswordcoffe" };
            
            return View(admin);
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public async Task<IActionResult> Event(string id)
        {

            return View(await db.Events.FirstOrDefaultAsync(x => x.Id == id));
        }

        public async Task<IActionResult> Events()
        {
            return View(await db.Events.ToListAsync());
        }

        public IActionResult Main()
        {
            return View();
        }

        [Authorize]
        public IActionResult Index()
        {
            return Content(User.Identity.Name);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
