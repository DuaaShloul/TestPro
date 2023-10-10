using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please Enter UserName")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
     
    }
}
