using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Account
{
    public class RegistrationAdminViewModel:RegisterViewModel
    {
        public List<SelectListItem> Roles { get; set; }
        public string UserRole { get; set; }



    }
}
