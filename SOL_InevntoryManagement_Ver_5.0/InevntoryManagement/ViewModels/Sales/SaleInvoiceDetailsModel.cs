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
        public string SellingPerson { get; set; }
        public string SellingFrom { get; set; }
        public string SellingType { get; set; }
        public int TotalAmount        { get; set; }
        public int Dues        { get; set; }
        public int Transport        { get; set; }
        public int Others        { get; set; }
        public int GrossAmount { get; set; }
        public int Discount { get; set; }
        public int NetAmount        { get; set; }
        public int PaymentOnCash { get; set; }


        public List<SaleInvoiceProductDetails> saleInvoiceProductDetails { get; set; } = new List<SaleInvoiceProductDetails>();














    }



    public class SaleInvoiceProductDetails
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
