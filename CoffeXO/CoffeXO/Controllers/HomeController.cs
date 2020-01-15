using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeXO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using CoffeXO.Contexts;
using System.Collections.Generic;

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
        public async Task<bool> EditDishApi([FromForm]Dish ph)
        {
            var req = Request;

            var ph2 = await db.Dishes.FirstOrDefaultAsync(x => x.Id == ph.Id);
            if (ph2 == null)
            {
                return false;
            }
            ph2.Name = ph.Name;
            ph2.Percent = ph.Percent;
            ph2.Price = ph.Price;
            ph2.Sale = ph.Sale;
            await db.SaveChangesAsync();
            return true;
        }

        [Authorize]
        public async Task<IActionResult> EditDish(string id)
        {
            return View(await db.Dishes.FirstOrDefaultAsync(x => x.Id == id));
        }


        [HttpPost]
        public async Task<bool> DeletePositionApi([FromForm]Dish d)
        {
            if (d == null)
            {
                return false;
            }
            db.Dishes.Remove(await db.Dishes.FirstOrDefaultAsync(x => x.Id == d.Id));
            await db.SaveChangesAsync();
            return true;
        }

        [HttpPost]
        public async Task<bool> AddPositionApi([FromForm]Dish d)
        {
            d.Id = Guid.NewGuid().ToString();
            db.Dishes.Add(d);
            await db.SaveChangesAsync();
            return true;
        }

        [Authorize]
        public IActionResult AddPosition()
        {
            return View();
        }

        [HttpPost]
        public async Task<bool> AddSlideApi([FromForm]Photo ph)
        {
            ph.Id = Guid.NewGuid().ToString();
            db.Photos.Add(ph);
            await db.SaveChangesAsync();
            return true;
        }

        [Authorize]
        public IActionResult AddSlide()
        {
            return View();
        }

        [HttpPost]
        public async Task<bool> EditSlideApi([FromForm]Photo ph)
        {
            var req = Request;

            var ph2 = await db.Photos.FirstOrDefaultAsync(x => x.Id == ph.Id);
            if (ph2 == null)
            {
                return false;
            }
            ph2.Name = ph.Name;
            ph2.ImgSrc = ph.ImgSrc;
            await db.SaveChangesAsync();
            return true;
        }

        [Authorize]
        public async Task<IActionResult> EditSlide(string id)
        {
            return View(await db.Photos.FirstOrDefaultAsync(x => x.Id == id));
        }

        [HttpPost]
        public async Task<bool> DeleteSlideApi([FromForm]Photo ph)
        {
            if (ph == null)
            {
                return false;
            }
            db.Photos.Remove(await db.Photos.FirstOrDefaultAsync(x => x.Id == ph.Id));
            await db.SaveChangesAsync();
            return true;
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

        [Authorize]
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

        [Authorize]
        public IActionResult AddEvent()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Admin()
        {
            var lists = new MyListsForAdmin
            {
                Events = await db.Events.ToListAsync(),
                Photos = await db.Photos.ToListAsync(),
                Dishes = await db.Dishes.ToListAsync()
            };


            return View(lists);
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

        public async Task<IActionResult> Main()
        {
            var allLists = new MyListsForMain
            {
                Photos = await db.Photos.ToListAsync(),
                Dishes = await db.Dishes.ToListAsync()
            };
            return View(allLists);
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

    public class MyListsForAdmin
    {
        public List<Event> Events { get; set; }
        public List<Photo> Photos { get; set; }
        public List<Dish> Dishes { get; set; }
    }

    public class MyListsForMain
    {
        public List<Photo> Photos { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
