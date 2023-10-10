using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        //[Required(ErrorMessage ="Enter your Name")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Enter your Mobile Number")]
        public string Mobile { get; set; }
        //[Required(ErrorMessage = "Enter your Email")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Enter your Restaurent Name")]
        public string RestaurentName { get; set; }
    }
}
