using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QRMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private AppDBContext db;
        public MenuViewComponent(AppDBContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke(int id, bool someCondition)
        {
            
            IQueryable<Menu> query = db.Menus.OrderByDescending(x => x.MenuId);

            if (someCondition)
            {
                query = query.Where(x => x.CategoryId == id);
            }

            var model =  query.ToList(); // Execute the query

            return View(model);
        }
    }
}
