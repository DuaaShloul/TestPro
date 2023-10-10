using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string ItemNameAR { get; set; }
        public string ItemNameEN { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        //public string LogoImageURL { get; set; }
        public string Details { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
