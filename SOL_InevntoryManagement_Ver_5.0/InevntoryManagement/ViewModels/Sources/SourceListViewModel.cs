using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sources
{
    public class SourceListViewModel:BasePaginate
    {
        public List<SourceListModel> sourceListModels { get; set; } = new List<SourceListModel>();

        public override string ControllerName { get =>"Source" ; }
        public override string ActionName { get => "GetSourceList"; }
    }



    public class SourceListModel
    {
        public int SourceId { get; set; }
        [Display(Name = "Source")]
        public string SourceName { get; set; }

        public bool IsSelected { get; set; }
    }
}
