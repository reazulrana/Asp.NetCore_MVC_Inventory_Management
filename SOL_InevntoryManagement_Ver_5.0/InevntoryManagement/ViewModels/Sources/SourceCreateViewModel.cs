using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sources
{
    public class SourceCreateViewModel
    {
        [Required]
        [Display(Name ="Source")]
        [Remote("FindSource", "Source")]
        public string SourceName { get; set; }
        public bool IsSelected { get; set; }

    }
}
