using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Category
{
    public class CategoryCreateViewModel
    {
        public CategoryCreateViewModel()
        {
            this.Brands = new List<string>();
        }


        [Required]
        [Display(Name ="Category Name")]
        [Remote("Search_Category_Duplicate", "Category")]
        public string Ctype { get; set; }
        public List<string> Brands { get; set; }

    }
}
