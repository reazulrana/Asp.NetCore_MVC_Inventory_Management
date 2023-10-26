using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dapper
{
   public class RawQueryService : IRawQueryService
    {
        public string GetSaletListQuery 
        {
            get
            {
                string query = "select s.SaleID, s.Invoice,convert(nvarchar(50), s.TrDate,103) as TrDate, b.name as Branch,p.Payments as PaymentType,a.TotalAmount,a.PaymentOnCash,a.Dues,a.Transport,a.Others,a.Discount,a.NetAmount from sales s";
                query = query + " inner join Branchs b on s.BranchId = b.Id";
                query = query + " inner join PaymentTypes p on s.PaymentTypeId = p.Id";
                query = query + " inner join amounts a on s.SaleID = a.TrID where a.TrType = 2";
                return query;


            }
        }


        public string GetSaleProductInfoByIdQuery
        {
            get
            {
                string query = "select products.id as ProdId, Products.Code, Products.description,Categories.CType as category,Models.ModelName as model,";
                query += " Products.Size, Products.Color,Products.photopath as photopath,MasterDetail.Qty,MasterDetail.Price, (MasterDetail.Qty * MasterDetail.Price) as TotlaPrice";
                query += " from sales inner join Amounts on sales.SaleID = Amounts.TrID inner join MasterDetail on Amounts.Id = MasterDetail.AmountId inner join Products on MasterDetail.ProductId = Products.Id";

                query += " inner join Models on Products.ModelId = Models.Id";

                query += " inner join Brands on Models.BrandId = Brands.Id";

                query += " inner join Categories on Brands.CategoryId = Categories.Id";
                query += " where sales.SaleID =@SaleID  and Amounts.TrType = 2";

                return query;

            }
        }

              public string Get_Single_Product_Balance_By_ID_Query
        {
            get
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

                return strquery;

            }
        }



        public string Get_Sale_Invoice_Details_Query
        {
            get
            {
                string query = " select sal.Invoice as invoiceno, convert(nvarchar(15), sal.TrDate,103) as InvoiceDate, Branchs.Name as Branch, ";
                query = query + " pm.Payments as InvoiceType,sal.remarks, sf.SaleFrom as SellingFrom, salt.Types as SellingType, ";
                query = query + " a.TotalAmount, a.Dues,a.Transport Transport, a.Others, a.GrossAmount, a.Discount, a.NetAmount,a.PaymentOnCash,";
                query = query + " Customers.CustName,Customers.Address,Customers.Contact from sales as sal";
                query = query + " inner join Branchs on sal.BranchId = Branchs.Id";
                query = query + " inner join Amounts a on sal.SaleID = a.TrID";
                query = query + " inner join PaymentTypes pm on sal.PaymentTypeId = pm.Id";
                query = query + " inner join SellFroms sf on sal.SaleFrom = sf.Id";
                query = query + " inner join SellingTypes salt on sal.SaleType = salt.Id";
                query = query + " inner join Customers on sal.CustomerID = Customers.ID";
                query = query + " where a.TrType = 2 and sal.SaleID = @saleid";


                return query;
            }
        }





        public string Get_Sale_Invoice_Product_Details_Query
        {
            get
            {
                string queryp = "Select sal.SaleID, p.Id as ProdId,p.Code,p.Description,cat.CType";
                queryp = queryp + " , m.ModelName,p.Size,p.Color,p.PhotoPath, ms.Qty,ms.Price,(ms.Qty * ms.Price) as TotalAmount  from Sales sal";
                queryp = queryp + " inner join Amounts a on sal.SaleID = a.TrID inner";
                queryp = queryp + " join MasterDetail ms on a.Id = ms.AmountId";
                queryp = queryp + " inner join Products p on ms.ProductId = p.Id";
                queryp = queryp + " inner join Models m on p.ModelId = m.Id";
                queryp = queryp + " inner join Brands br on m.BrandId = br.Id";
                queryp = queryp + " inner join Categories cat on br.CategoryId = cat.Id where a.TrType = 2 and sal.saleid=@saleid";



                return queryp;
            }
        }


    }
}
