using BussinessAccessLayer.ExtendModel;
using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Products
{
    public class ProductBalanceViewModel:BasePaginate
    {

      public  List<ProductBalance> productBalances { get; set; } = new List<ProductBalance>();
        public override string ControllerName { get; set; } = "Product";
        public override string ActionName { get; set; } = "GetProductBalance";

    }
}
