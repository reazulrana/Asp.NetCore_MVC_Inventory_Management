using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sources
{
    public class SourceListViewModel
    {
        public int SourceId { get; set; }
        [Display(Name="Source")]
        public string SourceName { get; set; }


    }
}
