using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QRMenu.Models.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required (ErrorMessage = "Please Enter Role Name")]
        [Display (Name ="Role Name :")]
        public string RoleName { get; set; }
    }
}
