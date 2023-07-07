using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InevntoryManagement.ViewModels;
namespace InevntoryManagement.ViewModels
{
    public class ManufactureEditViewModel:ManufactureCreateViewModel
    {
     
        [Required]
        public int id { get; set; }

    }
}
