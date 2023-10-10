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

namespace QRMenu.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Shady")]
    public class ShadyMenusController : Controller
    {
        private readonly AppDBContext _context;

        public ShadyMenusController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Administrator/ShadyMenus
        public async Task<IActionResult> Index()
        {
            var appDBContext = _context.shadyMenus.Include(s => s.Category);
            return View(await appDBContext.ToListAsync());
        }

        // GET: Administrator/ShadyMenus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shadyMenu = await _context.shadyMenus
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.ShadyMenuId == id);
            if (shadyMenu == null)
            {
                return NotFound();
            }

            return View(shadyMenu);
        }

        // GET: Administrator/ShadyMenus/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "NameAR");
            var model = new ShadyMenu();
            return View(model);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShadyMenuId,ItemNameAR,ItemNameEN,Price,ImageUrl,Details,CategoryId")] ShadyMenu menu, IFormFile ImageUrl)
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

        // GET: Administrator/ShadyMenus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shadyMenu = await _context.shadyMenus.FindAsync(id);
            if (shadyMenu == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", shadyMenu.CategoryId);
            return View(shadyMenu);
        }

        // POST: Administrator/ShadyMenus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShadyMenuId,ItemNameAR,ItemNameEN,Price,ImageUrl,Details,CategoryId")] ShadyMenu shadyMenu)
        {
            if (id != shadyMenu.ShadyMenuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shadyMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShadyMenuExists(shadyMenu.ShadyMenuId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", shadyMenu.CategoryId);
            return View(shadyMenu);
        }

        // GET: Administrator/ShadyMenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shadyMenu = await _context.shadyMenus
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.ShadyMenuId == id);
            if (shadyMenu == null)
            {
                return NotFound();
            }

            return View(shadyMenu);
        }

        // POST: Administrator/ShadyMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shadyMenu = await _context.shadyMenus.FindAsync(id);
            _context.shadyMenus.Remove(shadyMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShadyMenuExists(int id)
        {
            return _context.shadyMenus.Any(e => e.ShadyMenuId == id);
        }
    }
}
