using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Models
{
    public class Order
    {

        public int OrderId { get; set; }
        public string TableNumber { get; set; }
        public string CartItemsJson { get; set; } // Store cart items as JSON string
        public DateTime CreatedAt { get; set; }
    }
}
