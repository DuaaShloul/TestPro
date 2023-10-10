using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using QRMenu.Models;
using QRMenu.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text.Json;

namespace QRMenu.Controllers
{


    public class MenusController : Controller
    {


        private AppDBContext db;
        public MenusController(AppDBContext _db)
        {
            db = _db;
        }
        Menu M = new Menu();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Demo()
        {
           
            var imageUrl = db.Images
                           .Where(row => row.UserId == "007b4077-4716-4031-8d8e-a24560d38032")
                         .OrderByDescending(row => row.Id)
                           .Select(row => row.LogoUrl)
                           .FirstOrDefault();
            ViewBag.Logo = "../LogoImages/" + imageUrl;
            List<int> uniqueCategoryIds = db.Menus
                .Select(menu => menu.CategoryId)
                .Distinct()
                .ToList();
            ViewBag.CategoryList = uniqueCategoryIds;

            return View(db.Categories);
         

        }
        public IActionResult Demo2()
        {

            var imageUrl = db.Images
                           .Where(row => row.UserId == "007b4077-4716-4031-8d8e-a24560d38032")
                         .OrderByDescending(row => row.Id)
                           .Select(row => row.LogoUrl)
                           .FirstOrDefault();
            ViewBag.Logo = "../LogoImages/" + imageUrl;
            List<int> uniqueCategoryIds = db.Menus
                .Select(menu => menu.CategoryId)
                .Distinct()
                .ToList();
            ViewBag.CategoryList = uniqueCategoryIds;

            return View(db.Categories);


        }
        public IActionResult Shady()
        {

            var imageUrl = db.Images
                           .Where(row => row.UserId == "f22e519a-6ae1-4e31-addc-82a872c54e1c")
                         .OrderByDescending(row => row.Id)
                           .Select(row => row.LogoUrl)
                           .FirstOrDefault();
            ViewBag.Logo = "../LogoImages/" + imageUrl;
            List<int> uniqueCategoryIds = db.shadyMenus
                .Select(menu => menu.CategoryId)
                .Distinct()
                .ToList();
            ViewBag.CategoryList = uniqueCategoryIds;

            return View(db.Categories);

        }

        [HttpPost]
        public IActionResult AddToCart(string itemNameAR, decimal price, int quantity)
        {
            // Retrieve the existing cart items from the session or create a new list
            List<Cart> cartItems;
            string cartItemsJson = HttpContext.Session.GetString("Carts");

            if (cartItemsJson != null)
            {
                cartItems = JsonConvert.DeserializeObject<List<Cart>>(cartItemsJson);
            }
            else
            {
                cartItems = new List<Cart>();
            }

            // Add the item(s) to the cart with the specified quantity
            for (int i = 0; i < quantity; i++)
            {
                cartItems.Add(new Cart { Name = itemNameAR, Price = price });
            }

            // Serialize the list to JSON and save it in the session
            HttpContext.Session.SetString("Carts", JsonConvert.SerializeObject(cartItems));

            // Return a response if necessary (e.g., success message)
            return Json(new { success = true });
        }
        public IActionResult Cart()
        {
            var cartItemsJson = HttpContext.Session.GetString("Carts");

            if (cartItemsJson != null)
            {
                List<Cart> cartItems = JsonConvert.DeserializeObject<List<Cart>>(cartItemsJson);
                return View(cartItems);
            }
            else
            {
                // Handle the case when the cart is empty or hasn't been initialized
                List<Cart> emptyCart = new List<Cart>();
                return View(emptyCart);
            }
        }
        public IActionResult ShadyCart()
        {
            var cartItemsJson = HttpContext.Session.GetString("Carts");

            if (cartItemsJson != null)
            {
                List<Cart> cartItems = JsonConvert.DeserializeObject<List<Cart>>(cartItemsJson);
                return View(cartItems);
            }
            else
            {
                // Handle the case when the cart is empty or hasn't been initialized
                List<Cart> emptyCart = new List<Cart>();
                return View(emptyCart);
            }
        }
        [HttpPost]
        public IActionResult SaveOrder([FromBody] OrderViewModel orderViewModel)
        {
            try
            {
                // Serialize the cartItems list to JSON
                string cartItemsJson = JsonConvert.SerializeObject(orderViewModel.CartItemsJson);

                // Find the Jordan time zone by its id
                TimeZoneInfo jordanTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Jordan Standard Time");

                // Capture the current time in Jordan time zone
                DateTime jordanNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, jordanTimeZone);

                // Create a new Order instance and populate its properties
                var order = new Order
                {
                    TableNumber = orderViewModel.TableNumber,
                    CartItemsJson = cartItemsJson, // Store serialized cartItems 
                    CreatedAt = jordanNow  // Capture the current time in Jordan time zone
                };

                // Save the order to the database
                db.Orders.Add(order);
                db.SaveChanges();

                // Return a success response
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the save process
                return Json(new { success = false, error = ex.Message });
            }
        }
    }
}
