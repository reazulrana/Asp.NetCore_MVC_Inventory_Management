using BussinessAccessLayer.ExtendModel;
using BussinessAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dapper
{
    public interface IService
    {
        SaleInvoiceInfo GetSaleInvoiceById(int id);
        List<SaleInvoiceInfo> GetAllInvoiceList { get; }
        Amount GetSaleAmountByTrID(int id);
        List<ProductInfo> GetSaleProductInfoById(int SaleId);
    }
}
