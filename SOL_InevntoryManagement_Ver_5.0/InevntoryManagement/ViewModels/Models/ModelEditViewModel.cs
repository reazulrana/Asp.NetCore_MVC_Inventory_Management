using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Models
{
    public class ModelEditViewModel:ModelCreateViewModel
    {
        public int ModelId { get; set; }

        [Required]
        [Display(Name ="Model")]
        public string ModelName { get; set; }
              
        public List<SelectListItem> Brands { get; set; } = new List<SelectListItem>();
    }
}
