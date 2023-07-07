using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels
{
    public class ManufactureDeleteViewModel
    {

        [Required]
        public int id { get; set; }
        [Required]
        [Display(Name = "Manufacture Name")]
        public string ManufactureName { get; set; }
    }
}
