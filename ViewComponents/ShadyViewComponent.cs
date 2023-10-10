using Microsoft.AspNetCore.Mvc;
using QRMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.ViewComponents
{
    public class ShadyViewComponent : ViewComponent
    {
        private AppDBContext db;
        public ShadyViewComponent(AppDBContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke(int id, bool someCondition)
        {

            IQueryable<ShadyMenu> query = db.shadyMenus.OrderByDescending(x => x.ShadyMenuId);

            if (someCondition)
            {
                query = query.Where(x => x.CategoryId == id);
            }

            var model = query.ToList(); // Execute the query

            return View(model);
        }
    
}
}
