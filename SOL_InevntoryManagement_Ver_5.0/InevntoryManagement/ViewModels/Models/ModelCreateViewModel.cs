using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Models
{
    public class ModelCreateViewModel
    {

        [Display(Name ="Brand")]
        public int brandId { get; set; }
        [Display(Name ="Category")]
        public List<SelectListItem> Categories { get; set; }
        //public List<SelectListItem> Brands { get; set; }

        [Required]
        public List<string> Models { get; set; }


    }
}
