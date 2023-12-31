﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="User Name")]
        [Remote("IsEmailInUse", "Account")]
        //[ValidEmailDomain(domainName: "gmail.com", ErrorMessage = "Email Domain Must Be gmail.com")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password And Confirmation Password Do Not Match")]
        public string ConfirmPassword { get; set; }
    }
}
