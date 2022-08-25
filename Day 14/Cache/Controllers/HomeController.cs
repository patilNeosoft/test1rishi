using Cache.Context;
using Cache.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace Cache.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        private readonly UserDbContext _db;
        public HomeController(IMemoryCache memoryCache, UserDbContext db)
        {
            _memoryCache = memoryCache;
            _db = db;
        }
        
        public IActionResult Index()
        {
            //declare a list
            List<User> users;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            if (!_memoryCache.TryGetValue("users", out users))
            {
                //pass it to cache memory
                _memoryCache.Set("Users", _db.UserTb.ToList());
            }
            users = _memoryCache.Get("Users") as List<User>;
            stopWatch.Stop();
            ViewBag.TotalRows = users.Count;
            ViewBag.TotalTime = stopWatch.Elapsed;
            return View(users);
        }

        
        
    }
}