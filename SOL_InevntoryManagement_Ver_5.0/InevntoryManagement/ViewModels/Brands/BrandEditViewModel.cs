using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BussinessAccessLayer.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InevntoryManagement.ViewModels.Brands
{
    public class BrandEditViewModel
    {

        public List<SelectListItem> Categories { get; set; }
        [Required]
        [Display(Name = "Brand")]
        public string brandName { get; set; }
        [Required]
        public int brandId { get; set; }
        [Required]
        [Display(Name ="Category")]
        public int categoryId { get; set; }




    }
}
