using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sizes
{
    public class SizeEditViewModel:SizeCreateViewModel
    {

        [Required]
        public int SizeId { get; set; }
        [Required]
        public string Size { get; set; }
    }
}
