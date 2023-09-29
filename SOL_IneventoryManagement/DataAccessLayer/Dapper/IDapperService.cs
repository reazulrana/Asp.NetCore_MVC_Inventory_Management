using BussinessAccessLayer.ExtendModel;
using BussinessAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dapper
{
    public interface IDapperService
    {
        #region Sales Section
        SaleInvoiceInfo GetSaleInvoiceById(int id);
        List<SaleInvoiceInfo> GetAllInvoiceList { get; }
        List<SaleDetails> GetSaletList { get; }




        #endregion

        #region Amounts Section
        Amount GetSaleAmountByTrID(int id);
        #endregion

        #region Products Section
        List<ProductInfo> GetSaleProductInfoById(int SaleId);
        List<ProductBalance> GetProductBalance { get; }
        ProductBalance GetProductBalanceById(int id);

        List<ProductBalance> GetProductBalanceSatrtwith(string term, string searchfield);


        #endregion

    }
}
