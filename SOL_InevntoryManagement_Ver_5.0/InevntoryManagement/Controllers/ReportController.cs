﻿using AspNetCore.Reporting;
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
using System.Data;
using System.Reflection;
using System.Text;
using InevntoryManagement.Models;

namespace InevntoryManagement.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDapperService _service;

        public ReportController(IWebHostEnvironment webHostEnvironment, IUnitOfWork unitOfWork, IDapperService service)
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


        [HttpGet]
        public IActionResult PrintSaleInvoice(int saleid)
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
            param.Add("pInvoiceDate", sale.TrDate.ToShortDateString().ToString());
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
            param.Add("pCompanyName","Company Name: " + CompanyInformation.Name);
            param.Add("pCompanyAddress", "Address: " + CompanyInformation.Address);
            param.Add("pCompanyContact", "Contact No: " + CompanyInformation.Contact);



            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("dsSaleProductInfo", saleinvoice.ProductInfos);
            
            //localReport.AddDataSource("dsSale", saleinvoice);
            //localReport.AddDataSource("dsAmount", saleinvoice.amount);
            //localReport.AddDataSource("dsCustomer", customer);


            var result = localReport.Execute(RenderType.Pdf, extension, param, mimtype);
                       
            return File(result.MainStream,"application/pdf");
        }





        public IActionResult saveCSV<T>(List<T> EData)
        {
            StringBuilder str = new StringBuilder();

            //var tmptype = EData.FirstOrDefault();

            PropertyInfo[] lst = typeof(T).GetProperties();
            List<PropertyInfo> lst1 = lst.ToList();

            DataTable dt = ListtoDatatableConverter.ToDataTable<T>(EData);

            string colname = "";


            for (int i = 0; i < lst.Count(); i++)
            {
                colname = colname + lst[i].Name + ",";
            }



            str.AppendLine(colname);





            for (int sl = 0; sl < dt.Rows.Count; sl++)
            {

                DataRow d = dt.Rows[sl];
                string strdata = "";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    strdata = strdata + d[i].ToString() + ",";
                }


                str.AppendLine(strdata);
            }


            return File(Encoding.UTF8.GetBytes(str.ToString()), "text/csv");

        }



    }
}
