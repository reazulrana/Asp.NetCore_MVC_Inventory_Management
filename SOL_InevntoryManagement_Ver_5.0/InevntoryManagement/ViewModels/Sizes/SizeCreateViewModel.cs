using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sizes
{
    public class SizeCreateViewModel
    {
        [Required]
        [Remote("FindSize","Size")]
        public string Size { get; set; }

        [Required]
        public int Type{ get; set; }
        public bool IsSelected { get; set; }
        public  List<SelectListItem> Types { get; set; }

    }
}
