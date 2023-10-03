using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sizes
{
    public class SizeListViewModel:BasePaginate
    {
        public List<SizeListModel> sizeListModels { get; set; } = new List<SizeListModel>();
        public override string ControllerName { get; set; } = "Size";
        public override string ActionName { get; set; } = "SizeList";

    }

    public class SizeListModel
    {
        public int SizeId { get; set; }

        public string SizeName { get; set; }

        public string sizeType { get; set; }
    }
}
