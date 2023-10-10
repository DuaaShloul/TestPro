using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Models
{
    public class AppDBContext : IdentityDbContext 
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }

        public DbSet<ShadyMenu> shadyMenus  { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ImageModel> Images { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
