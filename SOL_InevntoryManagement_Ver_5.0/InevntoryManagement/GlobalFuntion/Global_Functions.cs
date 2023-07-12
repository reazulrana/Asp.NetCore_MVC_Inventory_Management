using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


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

    }
}
