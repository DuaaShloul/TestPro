using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QRMenu.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Controllers
{
    public class HomeController : Controller
    {  
    private AppDBContext db;
     
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , AppDBContext _db )
        {
            db = _db;
            _logger = logger;
        
        }
        [ResponseCache(Duration = 3600)]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
     
        public IActionResult Index([Bind("Name,Mobile,Email,RestaurentName")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
       
            return View(contact);
        }

        public IActionResult IndexAR()
        {
            return View();
        }

        [HttpPost]

        public IActionResult IndexAR([Bind("Name,Mobile,Email,RestaurentName")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(contact);
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
