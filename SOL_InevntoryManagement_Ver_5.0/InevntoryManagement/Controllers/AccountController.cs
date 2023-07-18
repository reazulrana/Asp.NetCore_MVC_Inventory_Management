using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InevntoryManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using InevntoryManagement.ViewModels.Account;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InevntoryManagement.Controllers
{

    //[Authorize(Roles ="Admin,Manager")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,RoleManager<IdentityRole> roleManager)

        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var user = userManager.Users.Any();
            if(!user)
            {
                return RedirectToAction("Registration_Admin", "Account");

            }
            
            return View();

        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.IsRemember, false);

                if (result.Succeeded)
                {
                    RedirectToAction("Index", "Home");
                }

            }

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Registration_Admin()
        {
            RegistrationAdminViewModel model = new RegistrationAdminViewModel();
            var roles = roleManager.Roles;

            if (roles.Count() == 0)
            {
                model.Roles = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                         Text="Admin", Value="Admin"
                    },
                    new SelectListItem()
                    {
                         Text="User", Value="User"
                    },
                };
            }
            else
            {
                model.Roles = (from obj in roleManager.Roles
                               select new SelectListItem()
                               {
                                   Value = obj.Id,
                                   Text = obj.Name,

                               }).ToList();
            }
                        return View(model);

        }

        [HttpPost]
        //[Authorize(Roles ="Admin")]
        public async Task<IActionResult> Registration_Admin(RegistrationAdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                


                ApplicationUser user = new ApplicationUser()
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var result = await userManager.CreateAsync(user, model.Password);


                if (result.Succeeded)
                {
                    IdentityRole role = new IdentityRole()
                    {
                        Name = model.UserRole
                    };
                    var roleresult = roleManager.CreateAsync(role);
                    if (roleresult != null)
                    {
                        await userManager.AddToRoleAsync(user, role.Name);
                    }

                    if(signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

            }
            return View();
        }



        [HttpGet]
        //[Authorize(Roles ="Admin")]
        public IActionResult Registration()
        {
            return View();
        }

      
       
    
    }
}
