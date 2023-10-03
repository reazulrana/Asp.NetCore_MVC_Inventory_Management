using BussinessAccessLayer.ExtendModel;
using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sales
{
    public class SaleDetailsViewModel:BasePaginate
    {

        public List<SaleDetailsViewModels> saleDetailsViewModels { get; set; } = new List<SaleDetailsViewModels>();
        

        
    }

    public class SaleDetailsViewModels
    {
        public int SaleID { get; set; }
        public string Invoice { get; set; }
        public string TrDate { get; set; }
        public string Branch { get; set; }
        public string PaymentType { get; set; }
        public int TotalAmount { get; set; }
        public int PaymentOnCash { get; set; }
        public int Dues { get; set; }
        public int Transport { get; set; }
        public int Others { get; set; }
        public int Discount { get; set; }
        public int NetAmount { get; set; }
    }



}
