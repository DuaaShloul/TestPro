using Microsoft.AspNetCore.Mvc;
using QRMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private AppDBContext db;
        public CategoryViewComponent(AppDBContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            return View(db.Categories.OrderByDescending(x => x.CategoryId));
        }
    }
}
