using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Products
{
    public class ProductListViewModel
    {

   
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        //public int ModelId { get; set; } //using for relationship
        public string Color { get; set; }
        public string SizeName { get; set; }
        public string SizeType { get; set; }
        public int Unitprice { get; set; }
        public int OpeningBalance { get; set; }
        public int OpeningQty { get; set; }
        public DateTime CreatedDate { get; set; }
        public string VendorName { get; set; }
        public string ManufactureName { get; set; }
        public string BinNo { get; set; }
        public string PhotoPath { get; set; }
        public string Remarks { get; set; }
        public int DiscountPrice { get; set; }


    }
}
