using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sales
{
    public class SaleListViewModel:BasePaginate
    {

        public List<SaleDetailsViewModels> saleDetailsViewModels { get; set; } = new List<SaleDetailsViewModels>();

        public override string ControllerName { get; set; } = "Sale";
        public override string ActionName { get; set; } = "GetSaleList";
        public override void ChangeActionName(string actionname = null)
        {
            ActionName = actionname;

        }
    }
}
