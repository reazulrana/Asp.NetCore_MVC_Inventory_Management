using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InevntoryManagement.Models;
using Microsoft.AspNetCore.Identity;

namespace InevntoryManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppDbContext> userManager;
        private readonly SignInManager<AppDbContext> signInManager;

        public AccountController(UserManager<AppDbContext> userManager, SignInManager<AppDbContext> signInManager)

        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Registration()
        {
            return View();
        }
    }
}
