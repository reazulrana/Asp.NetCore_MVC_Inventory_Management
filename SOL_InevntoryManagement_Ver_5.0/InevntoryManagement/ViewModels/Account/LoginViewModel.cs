using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        //[Remote("IsEmailInUse", "Account")]
        //[ValidEmailDomain(domainName: "gmail.com", ErrorMessage = "Email Domain Must Be gmail.com")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsRemember { get; set; }


    }
}
