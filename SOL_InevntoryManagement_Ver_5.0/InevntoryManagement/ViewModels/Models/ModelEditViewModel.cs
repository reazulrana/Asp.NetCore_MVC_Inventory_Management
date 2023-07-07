using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Models
{
    public class ModelEditViewModel
    {
        public int ModelId { get; set; }
        [Required]
        public int BrandId { get; set; }
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        [Display(Name = "Brand")]
        public string BrandName { get; set; }
        [Required]
        [Display(Name ="Model")]
        public string ModelName { get; set; }
    }
}
