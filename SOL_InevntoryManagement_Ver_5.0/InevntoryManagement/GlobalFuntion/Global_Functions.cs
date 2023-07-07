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

    }
}
