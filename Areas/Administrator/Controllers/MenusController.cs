using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QRMenu.Models;
using System.Text.Json;

namespace QRMenu.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "DemoAdmin")]
    public class MenusController : Controller
    {
        private readonly AppDBContext _context;

        public MenusController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Administrator/Menus
        public async Task<IActionResult> Index()
        {
            var appDBContext = _context.Menus.Include(m => m.Category);
            return View(await appDBContext.ToListAsync());
        }

        // GET: Administrator/Menus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus
                .Include(m => m.Category)
                .FirstOrDefaultAsync(m => m.MenuId == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // GET: Administrator/Menus/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "NameAR");
            var model = new Menu();
            return View(model);
            
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MenuId,ItemNameAR,ItemNameEN,Price,ImageUrl,Details,CategoryId")] Menu menu , IFormFile ImageUrl)
        {
            if (ModelState.IsValid)
            {
                if (ImageUrl != null && ImageUrl.Length > 0)
                {
                    var uniqueFileName = Guid.NewGuid().ToString() + "_" + ImageUrl.FileName;

                    // Determine the path where you want to save the image
                    var imagePath = Path.Combine("wwwroot/ItemImages", uniqueFileName);

                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        await ImageUrl.CopyToAsync(stream);
                    }
                    menu.ImageUrl = "../ItemImages/" + uniqueFileName;
                }
            
                _context.Add(menu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", menu.CategoryId);
            return View(menu);
        }

        // GET: Administrator/Menus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "NameAR", menu.CategoryId);
            return View(menu);
        }

        // POST: Administrator/Menus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MenuId,ItemNameAR,ItemNameEN,Price,ImageUrl,Details,CategoryId")] Menu menu , IFormFile ImageUrl)
        {
            if (id != menu.MenuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ImageUrl != null && ImageUrl.Length > 0)
                    {
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + ImageUrl.FileName;

                        // Determine the path where you want to save the image
                        var imagePath = Path.Combine("wwwroot/ItemImages", uniqueFileName);

                        using (var stream = new FileStream(imagePath, FileMode.Create))
                        {
                            await ImageUrl.CopyToAsync(stream);
                        }
                        menu.ImageUrl = "../ItemImages/" + uniqueFileName;
                    }
                    _context.Update(menu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuExists(menu.MenuId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", menu.CategoryId);
            return View(menu);
        }

        // GET: Administrator/Menus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus
                .Include(m => m.Category)
                .FirstOrDefaultAsync(m => m.MenuId == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // POST: Administrator/Menus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menu = await _context.Menus.FindAsync(id);
            _context.Menus.Remove(menu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuExists(int id)
        {
            return _context.Menus.Any(e => e.MenuId == id);
        }

        public IActionResult OrderDetails(int orderId)
        {
            // Retrieve the order with the specified orderId from your data source
            Order order = _context.Orders.FirstOrDefault(o => o.OrderId == orderId);

            if (order == null)
            {
                return NotFound();
            }
            var cartItemsJson = JsonSerializer.Serialize(order.CartItemsJson);
            ViewBag.CartItemsJson = cartItemsJson;
            // Pass the order to the OrderDetails view
            return View(order);
        }
        public IActionResult AllOrders()
        {
            // Retrieve a list of all orders from your data source, sorted by CreatedAt
            List<Order> orders = _context.Orders.OrderByDescending(o => o.CreatedAt).ToList();

            // Pass the sorted list of orders to the AllOrders view
            return View(orders);
        }
    }
}
