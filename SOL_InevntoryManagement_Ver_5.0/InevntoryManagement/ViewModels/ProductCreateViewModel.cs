using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessAccessLayer.Model;
using Microsoft.AspNetCore.Http;

namespace InevntoryManagement.ViewModels
{
    public class ProductCreateViewModel
    {
        public int PID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int ModelID { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Dimension { get; set; }
        public int Unitprice { get; set; }
        public int OpeningBalance { get; set; }
        public int OpeningQty { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Vendor { get; set; }
        public string Manufacture { get; set; }
        public string BinNo { get; set; }
        public IFormFile PhotoPath { get; set; }
        public string Remarks { get; set; }
        public int DiscountPrice { get; set; }


    }
}
