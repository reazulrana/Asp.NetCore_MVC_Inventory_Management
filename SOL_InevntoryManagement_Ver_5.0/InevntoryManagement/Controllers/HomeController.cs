using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using InevntoryManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InevntoryManagement.Controllers
{


    public class exportdata
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Age { get; set; }

        public void GetMessage()
        {

        }
    }
    public class HomeController : Controller
    {
        

        public HomeController()
        {
           
            



          



        }
        public IActionResult Index()
        {
            return View();

        }


        public IActionResult admin_profile()
        {


            ExportData.ConvertoExcelToPDF("RELService.xlsx", @"E:\");
            

            return View();

        }
      

        
    }
}
