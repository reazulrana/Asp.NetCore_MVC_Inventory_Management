﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Purchase
{
    public class PurchaseEditViewModel:PurchaseCreateViewModel
    {
        public int id { get; set; }
        public int AmountId { get; set; }




       //public  List<PurchaseProductInfo> PurchaseProductInfos { get; set; } = new List<PurchaseProductInfo>();


    }
}
