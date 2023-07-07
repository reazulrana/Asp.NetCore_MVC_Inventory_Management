using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace InevntoryManagement.ViewModels.Brands
{
    public class BrandCreateViewModel
    {
        public BrandCreateViewModel()
        {
            this.Categories = new List<SelectListItem>();
            //this.Brands = new List<string>();
        }
        [Required(ErrorMessage ="Field is required")]
        [Display(Name ="Category")]
        public int cateid { get; set; }

        public List<SelectListItem> Categories { get; set; } 

        [Required]
        public List<string> Brands { get; set; }


    }
}
