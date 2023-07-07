using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels
{
    public class ManufactureCreateViewModel
    {

        [Required]
        [Display(Name ="Manufacture Name")]
        [Remote("IsManufactureExist", "Manufacture")]
        public string ManufactureName { get; set; }
    }
}
