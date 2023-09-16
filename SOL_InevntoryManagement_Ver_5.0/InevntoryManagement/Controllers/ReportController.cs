using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using InevntoryManagement.ViewModels.Sales;
using DataAccessLayer.Services.Interface;
using BussinessAccessLayer.Model;
using DataAccessLayer.Dapper;
using BussinessAccessLayer.ExtendModel;

namespace InevntoryManagement.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IService _service;

        public ReportController(IWebHostEnvironment webHostEnvironment, IUnitOfWork unitOfWork, IService service)
        {
            this._webHostEnvironment = webHostEnvironment;
            this._unitOfWork = unitOfWork;
            this._service = service;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Print(int saleid)
        {
            //SaleInvoice tmodel = new SaleInvoice()
            //{
            //    Invoice = model.Invoice,
            //    TrDate = model.TrDate,
            //};

            //if (model.ProductIds.Count > 0)
            //{
            //    for (int i = 0; i < model.ProductIds.Count; i++)
            //    {
            //        tmodel.ProductIds.Add(model.ProductIds[i]);
            //        model.Codes.Add(model.Codes[i]);
            //        model.Colors.Add(model.Colors[i]);
            //        model.Descriptions[i] = model.Descriptions[i];
            //        model.Models.Add(model.Models[i]);
            //        model.Images.Add(model.Images[i]);
            //        model.Prices.Add(model.Prices[i]);
            //        model.Qtys.Add(model.Qtys[i]);
            //        model.Sizes.Add(model.Sizes[i]);
            //    }
            //}


            var saleinvoice = _service.GetSaleInvoiceById(saleid);
            var sale = _unitOfWork.Sales.GetByID(saleid);
            var branch = _unitOfWork.Branchs.GetByID(sale.BranchId);
            var paymentType = _unitOfWork.PaymentTypes.GetByID(sale.PaymentTypeId);
            //var amount = _unitOfWork.Amounts.Get().Where(x => x.TrID == sale.SaleID && x.TrType == 1).FirstOrDefault();

            string mimtype = "";
            int extension = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\rptSaleInvoice.rdlc";
            var customer = _unitOfWork.Customers.GetByID(saleinvoice.CustomerID);

            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("pcn", customer.CustName);
            param.Add("pca", customer.Address);
            param.Add("pccn", customer.Contact);

            // Sale Table
            param.Add("pinvoice", sale.Invoice);
            param.Add("pInvoiceDate", sale.TrDate.ToString());
            param.Add("pBranch", branch.Name);
            param.Add("pPaymentType", paymentType.Payments);
            param.Add("pRemarks", sale.Remarks);
            
            //amount table 
            param.Add("pttlProductAmount", saleinvoice.amount.TotalAmount.ToString());
            param.Add("pPaymentOnCash", saleinvoice.amount.PaymentOnCash.ToString());
            param.Add("pDues", saleinvoice.amount.Dues.ToString());
            param.Add("pTransport", saleinvoice.amount.Transport.ToString());
            param.Add("pOthers", saleinvoice.amount.Others.ToString());
            param.Add("pGrossAmount", saleinvoice.amount.GrossAmount.ToString());
            param.Add("pDiscount", saleinvoice.amount.Discount.ToString());
            param.Add("pNetAmount", saleinvoice.amount.NetAmount.ToString());
            
            //Seller company information
            param.Add("pCompanyName", CompanyInformation.Name);
            param.Add("pCompanyAddress", CompanyInformation.Address);
            param.Add("pCompanyContact", CompanyInformation.Contact);



            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("dsSaleProductInfo", saleinvoice.ProductInfos);
            
            //localReport.AddDataSource("dsSale", saleinvoice);
            //localReport.AddDataSource("dsAmount", saleinvoice.amount);
            //localReport.AddDataSource("dsCustomer", customer);


            var result = localReport.Execute(RenderType.Pdf, extension, param, mimtype);
                       
            return File(result.MainStream,"application/pdf");
        }
    }
}
