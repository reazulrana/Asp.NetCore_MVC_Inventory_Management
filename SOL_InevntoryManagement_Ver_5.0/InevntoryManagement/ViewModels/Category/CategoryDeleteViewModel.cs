using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Category
{
    public class CategoryDeleteViewModel
    {

        [Required]
        public int ID { get; set; }
        public string Ctype { get; set; }
        [Display(Name ="Delete Nested Brand")]
        public bool DeleteBrand { get; set; }


    }
}
