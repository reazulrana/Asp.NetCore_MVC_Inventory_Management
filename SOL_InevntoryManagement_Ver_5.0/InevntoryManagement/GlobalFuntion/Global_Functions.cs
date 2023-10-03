using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using InevntoryManagement.GlobalFuntion;


namespace InevntoryManagement.GlobalFuntion
{
    public  class Global_Functions
    {

        private  static   HttpContextAccessor a = new HttpContextAccessor();

        public static void SetMessage(string message, string status)
        {
            
            a.HttpContext.Session.SetString("message", message);
            a.HttpContext.Session.SetString("status", status);

        }

        public static string SaveErrorMessage(string TableName)
        {

            return $"{ TableName } Can Not Create For Some Reason Please Contach With Administration";
        }

        public static string SaveMessage(string TableName)
        {

            return $"{ TableName } Created Successfully";
        }

        public static string DeleteMessage(string TableName)
        {

            return $"{ TableName } Deleted Successfully";
        }


        public static string DuplicateErrorMessage(string TableName)
        {

            return $"{ TableName } You Enterd Is Duplicat";
        }


        public static string ZeroBeforeInvoiceNo(int invoiceno)
        {

            string output = "";
            output = invoiceno.ToString().Length == 1 ? "000000" + invoiceno.ToString() : invoiceno.ToString().Length == 2 ? "00000" + invoiceno : invoiceno.ToString().Length == 3 ? "0000" + invoiceno : invoiceno.ToString().Length == 4 ? "000" + invoiceno : invoiceno.ToString().Length == 5 ? "00" + invoiceno : invoiceno.ToString().Length == 6 ? "0" + invoiceno : invoiceno.ToString();
                return output;
        }
        public static bool IsFileExist(string folderpath,string filename)
        {
            string acualpath = Path.Combine(folderpath, ImagePath.GetProductImagePath(filename));

            bool output = System.IO.File.Exists(acualpath);

            return output;
        }



    }
}
