using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Purchase
{
    public class PurchaseProductInfo
    {
        public int purchaseid { get; set; }
        public int ProdId { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string model { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public string photopath { get; set; }
        public int qty { get; set; }
        public int price { get; set; }

    }
}
