using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Measures
{
    public class MeasureCreateViewModel
    {

        [Required]
        [Display(Name ="Measurement")]
        public string Measurements { get; set; }
    }
}
