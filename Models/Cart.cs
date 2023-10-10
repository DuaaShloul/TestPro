using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
