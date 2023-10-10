using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Models.ViewModels
{
    public class OrderViewModel
    {
        public string TableNumber { get; set; }
        public List<CartItemViewModel> CartItemsJson { get; set; }
    }

    public class CartItemViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
