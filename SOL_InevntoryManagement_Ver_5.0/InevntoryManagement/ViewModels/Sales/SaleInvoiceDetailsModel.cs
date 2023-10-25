using BussinessAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sales
{
    public class SaleInvoiceDetailsModel
    {


        Customer customer { get; set; } = new Customer();

        public string CustomerType { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceDate	 { get; set; }
        public string Branch { get; set; }
        public string InvoiceType { get; set; }
        public string Remarks { get; set; }
        public string SellingFrom { get; set; }
        public string SellingType { get; set; }
        public int TotalAmount { get; set; }
        public int Dues { get; set; }
        public int Transport { get; set; }
        public int Others { get; set; }
        public int GrossAmount{ get; set; }
        public int Discount{ get; set; }
        public int NetAmount{ get; set; }
        public int PaymentOnCash { get; set; }
        public string CustName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }





        public List<SaleInvoiceProductDetails> saleInvoiceProductDetails { get; set; } = new List<SaleInvoiceProductDetails>();














    }



    public class SaleInvoiceProductDetails
    {
        public int saleid { get; set; }
        public int ProdId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string CType { get; set; }
        public string ModelName { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Photopath { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public int TotalAmount { get; set; }
    }
}
