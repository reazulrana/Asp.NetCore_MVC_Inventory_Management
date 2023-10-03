using InevntoryManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Products
{
    public class ProductListViewModel : BasePaginate
    {

        public List<ProductList> productList { get; set; } = new List<ProductList>();
        public override string ControllerName { get; set; } = "Product";
        public override string ActionName { get; set; } = "ProductList";

    }



    public class ProductList
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
        public string Measurement { get; set; } //new add
        public string Source { get; set; } //new add
        public int Pipeline { get; set; }  //new add
    }
}
