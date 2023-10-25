using BussinessAccessLayer.ExtendModel;
using BussinessAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace DataAccessLayer.Dapper
{
    public interface IDapperService
    {
        #region Sales Section
        SaleInvoiceInfo GetSaleInvoiceById(int id);
        List<SaleInvoiceInfo> GetAllInvoiceList { get; }
        List<SaleDetails> GetSaletList(string query);




        #endregion

        #region Amounts Section
        Amount GetSaleAmountByTrID(int id);
        #endregion

        #region Products Section
        List<ProductInfo> GetSaleProductInfoById(int SaleId);
        List<ProductBalance> GetProductBalance { get; }
        ProductBalance GetProductBalanceById(int id);

        List<ProductBalance> GetProductBalanceSatrtwith(string term, string searchfield);
        List<T> GetDynamicTableList<T>(string strquery, DynamicParameters param, CommandType commandtype);
       

        #endregion

    }
}
