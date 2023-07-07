using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sources
{
    public class SourceEditViewModel:SourceCreateViewModel
    {

        [Required(ErrorMessage ="Source Id Filed Is Required")]
        public int Id { get; set; }


    }
}
