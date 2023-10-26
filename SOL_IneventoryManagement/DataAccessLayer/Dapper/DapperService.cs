using BussinessAccessLayer.ExtendModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using BussinessAccessLayer.Model;

namespace DataAccessLayer.Dapper
{
    public class DapperService : IDapperService
    {
        private readonly IConfiguration _config;
        private string connectionstring = "";
        public DapperService(IConfiguration config)
        {
            this._config = config;
            connectionstring = _config.GetConnectionString("DatabasDbConnection");
        }

        public List<SaleInvoiceInfo> GetAllInvoiceList 
        {
            get
            {
                List<SaleInvoiceInfo> output = new List<SaleInvoiceInfo>();

                return output;
            }
        }

        public List<SaleDetails> GetSaletList(string query)
        { 
         
                List<SaleDetails> output = new List<SaleDetails>();

                using (IDbConnection con=new SqlConnection(connectionstring))
                {


                    output = con.Query<SaleDetails>(query, commandType: CommandType.Text).ToList();
                }


                return output;
            
        }

        public List<ProductBalance> GetProductBalance
        {
            get
            {


                string strquery = "select p.id, p.code,p.description,c.ctype,m.ModelName,p.size, sum(ms.qty) pqty,p.OpeningQty into  #tpurchase from Purchases pr";
                strquery = strquery + " inner join Amounts a on pr.PurchaseID = a.TrID";
                strquery = strquery + " inner join MasterDetail ms on a.id = ms.AmountId";
                strquery = strquery + " inner join Products p on ms.ProductId = p.Id";
                strquery = strquery + " inner join Models m on p.ModelId = m.Id";
                strquery = strquery + " inner join Brands br on m.BrandId = br.Id";
                strquery = strquery + " inner join Categories c on br.CategoryId = c.Id";
                strquery = strquery + " where a.TrType = 1";
                strquery = strquery + " group by p.id, p.code,p.description,c.ctype,m.ModelName,p.size,p.OpeningQty";


                strquery = strquery + " select p.id, p.code,p.description,c.ctype,m.ModelName,p.size, sum(ms.qty) as sqty,p.OpeningQty into  #tsale from Sales s";
                strquery = strquery + " inner join Amounts a on s.SaleID = a.TrID";
                strquery = strquery + " inner join MasterDetail ms on a.id = ms.AmountId";
                strquery = strquery + " inner join Products p on ms.ProductId = p.Id";
                strquery = strquery + " inner join Models m on p.ModelId = m.Id";
                strquery = strquery + " inner join Brands br on m.BrandId = br.Id";
                strquery = strquery + " inner join Categories c on br.CategoryId = c.Id";
                strquery = strquery + " where a.TrType = 2";
                strquery = strquery + " group by p.id, p.code,p.description,c.ctype,m.ModelName,p.size,p.OpeningQty";

                strquery = strquery + " select tp.Id, tp.Code,tp.Description,tp.CType,tp.ModelName,tp.Size, ";
                strquery = strquery + " coalesce(tp.pQty, 0) as purqty, coalesce(ts.sQty, 0) saleQty , ((coalesce(tp.pQty, 0)+tp.OpeningQty) - coalesce(ts.sQty, 0)) as Balance, tp.OpeningQty  from #tpurchase tp";
                strquery = strquery + " left join #tsale ts on tp.id=ts.Id";




                List<ProductBalance> output = new List<ProductBalance>();

                using(IDbConnection con=new SqlConnection(connectionstring))
                {

                    output = con.Query<ProductBalance>(strquery, commandType: CommandType.Text).ToList();

                }

                return output;
            }
        }

        public SaleInvoiceInfo GetSaleInvoiceById(int id)
        {
            SaleInvoiceInfo output = new SaleInvoiceInfo();
            
            DynamicParameters param = new DynamicParameters();

            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                param.Add("@id", id, dbType: DbType.Int32);
                output = con.Query<SaleInvoiceInfo>("select * from Sales where SaleID=@id", param, commandType: CommandType.Text).FirstOrDefault();
            }

            output.amount = GetSaleAmountByTrID(output.SaleID);
            output.ProductInfos = GetSaleProductInfoById(output.SaleID);

            return output;
        }


        public Amount GetSaleAmountByTrID(int trid)
        {
            Amount output = new Amount();

            DynamicParameters param = new DynamicParameters();

            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                param.Add("@id", trid, dbType: DbType.Int32);
                
                output = con.Query<Amount>("select * from Amounts where trId=@id and TrType=2", param, commandType: CommandType.Text).FirstOrDefault();
            }
            return output;
        }

        public List<ProductInfo> GetSaleProductInfoById(int SaleId)
        {


    

        List<ProductInfo> output = new List<ProductInfo>();
            DynamicParameters param = new DynamicParameters();
             string query = "select products.id as ProdId, Products.Code, Products.description,Categories.CType as category,Models.ModelName as model,";
            query += " Products.Size, Products.Color,Products.photopath as photopath,MasterDetail.Qty,MasterDetail.Price, (MasterDetail.Qty * MasterDetail.Price) as TotlaPrice";
            query += " from sales inner join Amounts on sales.SaleID = Amounts.TrID inner join MasterDetail on Amounts.Id = MasterDetail.AmountId inner join Products on MasterDetail.ProductId = Products.Id";

            query += " inner join Models on Products.ModelId = Models.Id";

            query += " inner join Brands on Models.BrandId = Brands.Id";

            query += " inner join Categories on Brands.CategoryId = Categories.Id";
            query += " where sales.SaleID =@SaleID  and Amounts.TrType = 2";

            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                param.Add("@SaleID", SaleId, dbType: DbType.Int32);
                output = con.Query<ProductInfo>(query, param, commandType: CommandType.Text).ToList();
            }
            return output;








        }

        public ProductBalance GetProductBalanceById(int id )
        {
            string strquery = "select p.id, p.code,p.description,c.ctype,m.ModelName,p.size, sum(ms.qty) pqty,p.Photopath into  #tpurchase from Purchases pr";
            strquery = strquery + " inner join Amounts a on pr.PurchaseID = a.TrID";
            strquery = strquery + " inner join MasterDetail ms on a.id = ms.AmountId";
            strquery = strquery + " inner join Products p on ms.ProductId = p.Id";
            strquery = strquery + " inner join Models m on p.ModelId = m.Id";
            strquery = strquery + " inner join Brands br on m.BrandId = br.Id";
            strquery = strquery + " inner join Categories c on br.CategoryId = c.Id";
            strquery = strquery + " where a.TrType = 1";
            strquery = strquery + " group by p.id, p.code,p.description,c.ctype,m.ModelName,p.size,p.Photopath";


            strquery = strquery + " select p.id, p.code,p.description,c.ctype,m.ModelName,p.size, sum(ms.qty) as sqty,p.Photopath into  #tsale from Sales s";
            strquery = strquery + " inner join Amounts a on s.SaleID = a.TrID";
            strquery = strquery + " inner join MasterDetail ms on a.id = ms.AmountId";
            strquery = strquery + " inner join Products p on ms.ProductId = p.Id";
            strquery = strquery + " inner join Models m on p.ModelId = m.Id";
            strquery = strquery + " inner join Brands br on m.BrandId = br.Id";
            strquery = strquery + " inner join Categories c on br.CategoryId = c.Id";
            strquery = strquery + " where a.TrType = 2";
            strquery = strquery + " group by p.id, p.code,p.description,c.ctype,m.ModelName,p.size,p.Photopath";

            strquery = strquery + " select tp.Id, tp.Code,tp.Description,tp.CType,tp.ModelName,tp.Size, ";
            strquery = strquery + " coalesce(tp.pQty, 0) as purqty, coalesce(ts.sQty, 0) saleQty , (coalesce(tp.pQty, 0) - coalesce(ts.sQty, 0)) as Balance,tp.photopath  from #tpurchase tp";
            strquery = strquery + " left join #tsale ts on tp.id=ts.Id where tp.id=@productId";
            DynamicParameters p = new DynamicParameters();
            p.Add("@productId", id, dbType: DbType.Int32);




            ProductBalance output = new ProductBalance();

            using (IDbConnection con = new SqlConnection(connectionstring))
            {

                output = con.Query<ProductBalance>(strquery,p, commandType: CommandType.Text).FirstOrDefault();

            }

            return output;
        }

        public List<ProductBalance> GetProductBalanceSatrtwith(string term, string searchfield)
        {

            string searchcrite = searchfield.ToLower() == "category" ? "tp.ctype like @term" : searchfield.ToLower() == "code" ? "tp.code like @term" : searchfield.ToLower() == "description" ? "tp.description like @term" : "tp.modelname like @term";



            string strquery = "select p.id, p.code,p.description,c.ctype,p.color,m.ModelName,p.size, sum(ms.qty) pqty,p.photopath,p.Unitprice,p.OpeningQty into  #tpurchase from Purchases pr";
            strquery = strquery + " inner join Amounts a on pr.PurchaseID = a.TrID";
            strquery = strquery + " inner join MasterDetail ms on a.id = ms.AmountId";
            strquery = strquery + " inner join Products p on ms.ProductId = p.Id";
            strquery = strquery + " inner join Models m on p.ModelId = m.Id";
            strquery = strquery + " inner join Brands br on m.BrandId = br.Id";
            strquery = strquery + " inner join Categories c on br.CategoryId = c.Id";
            strquery = strquery + " where a.TrType = 1";
            strquery = strquery + " group by p.id, p.code,p.description,c.ctype,p.color,m.ModelName,p.size,p.photopath,p.Unitprice,p.OpeningQty";


            strquery = strquery + " select p.id, p.code,p.description,c.ctype,p.color,m.ModelName,p.size, sum(ms.qty) as sqty,p.photopath,p.Unitprice,p.OpeningQty into  #tsale from Sales s";
            strquery = strquery + " inner join Amounts a on s.SaleID = a.TrID";
            strquery = strquery + " inner join MasterDetail ms on a.id = ms.AmountId";
            strquery = strquery + " inner join Products p on ms.ProductId = p.Id";
            strquery = strquery + " inner join Models m on p.ModelId = m.Id";
            strquery = strquery + " inner join Brands br on m.BrandId = br.Id";
            strquery = strquery + " inner join Categories c on br.CategoryId = c.Id";
            strquery = strquery + " where a.TrType = 2";
            strquery = strquery + " group by p.id, p.code,p.description,c.ctype,p.color,m.ModelName,p.size,p.photopath,p.Unitprice,p.OpeningQty";

            strquery = strquery + " select tp.Id, tp.Code,tp.Description,tp.CType,tp.ModelName,tp.Size,tp.color, ";
            strquery = strquery + " coalesce(tp.pQty, 0) as purqty, coalesce(ts.sQty, 0) saleQty , ((coalesce(tp.pQty, 0)+tp.OpeningQty) - coalesce(ts.sQty, 0)) as Balance,tp.photopath,tp.Unitprice  from #tpurchase tp";
            strquery = strquery + " left join #tsale ts on tp.id=ts.Id where " + searchcrite;
            DynamicParameters p = new DynamicParameters();
            p.Add("@term", term +"%", dbType: DbType.String);




            List<ProductBalance> output = new List<ProductBalance>();

            using (IDbConnection con = new SqlConnection(connectionstring))
            {

                output = con.Query<ProductBalance>(strquery, p, commandType: CommandType.Text).ToList();

            }

            return output;
        }

        public List<T> GetDynamicTableList<T>(string strquery,  DynamicParameters param, CommandType commandtype)
        {
            List<T> output = new List<T>();
          
            using (IDbConnection con=new SqlConnection(connectionstring))
            {
                output = con.Query<T>(strquery, param, commandType: commandtype).ToList();
            }


            return output;
        }

       
    }
}
