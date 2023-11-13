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


            DataTable dt = getData();
            //Name of File  
            string fileName = "Sample.xlsx";
            using (XLWorkbook wb = new XLWorkbook())
            {
                //Add DataTable in worksheet  
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    //Return xlsx Excel File  
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                }
            }


            return View();

        }

        public DataTable getData()
        {
            //Creating DataTable  
            DataTable dt = new DataTable();
            //Setiing Table Name  
            dt.TableName = "EmployeeData";
            //Add Columns  
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("City", typeof(string));
            //Add Rows in DataTable  
            dt.Rows.Add(1, "Anoop Kumar Sharma", "Delhi");
            dt.Rows.Add(2, "Andrew", "U.P.");
            dt.AcceptChanges();
            return dt;
        }
        // GET: Home  
        public ActionResult WriteDataToExcel()
        {
            DataTable dt = getData();
            //Name of File  
            string fileName = "Sample.xlsx";
            using (XLWorkbook wb = new XLWorkbook())
            {
                //Add DataTable in worksheet  
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    //Return xlsx Excel File  
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                }
            }
        }

    }
}
