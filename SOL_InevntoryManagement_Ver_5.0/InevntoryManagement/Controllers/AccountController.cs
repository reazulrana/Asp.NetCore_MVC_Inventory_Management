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

                    return RedirectToAction("index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                ModelState.AddModelError(string.Empty, "Email Or Password Is Incorrect");



            }

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Registration_Admin()
        {
            RegistrationAdminViewModel model = new RegistrationAdminViewModel();


            model.Roles= UserRolesLoad(model.Roles);
           
                        return View(model);

            
        }


       


        [HttpPost]
        //[Authorize(Roles ="Admin")]
        public async Task<IActionResult> Registration_Admin(RegistrationAdminViewModel model)
        {


            if (ModelState.IsValid)
            {
                    IdentityRole _IdentityRole = null;
                IdentityResult _IdentityResult = null;


                ApplicationUser user = new ApplicationUser()
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var userresult = await userManager.CreateAsync(user, model.Password);


                if (userresult.Succeeded)
                {
                    //login if register successfully

                    var login = await signInManager.PasswordSignInAsync(user.Email, model.Password, false, false);

                    if (roleManager.Roles.Count() > 0)
                    {
                        //chekc role is exist or not into the database
                        _IdentityRole = roleManager.Roles.Where(x => x.Id == model.UserRole).FirstOrDefault();

                    }

                    if(_IdentityRole!=null)
                    {

                        if(!(await userManager.IsInRoleAsync(user, _IdentityRole.Name)))
                        {
                          _IdentityResult= await userManager.AddToRoleAsync(user, _IdentityRole.Name);
                        }
                        if (_IdentityResult.Succeeded)
                        {
                            if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                            {
                                RedirectToAction("Index", "Home");

                            }
                        }
                    }
                    else
                    {
                        IdentityRole role = new IdentityRole()
                        {
                            Name = model.UserRole
                        };
                        
                        _IdentityResult = await roleManager.CreateAsync(role);

                        if (_IdentityResult.Succeeded)
                        {
                            var addresult= await userManager.AddToRoleAsync(user, role.Name);
                            if (addresult.Succeeded)
                            {
                                
                                if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                                {
                                    RedirectToAction("Index", "Home");

                                }
                            }

                        }
                    }
                    

                    if(signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
             

            }

            model.Roles = UserRolesLoad(model.Roles);
            return View(model);
        }



        [HttpGet]
        //[Authorize(Roles ="Admin")]
        public IActionResult Registration()
        {
            return View();
        }



        //if role is empty then load deafault role to List<SelectListItem>
        // if role found to the database then load from database to List<SelectListItem> 
        private List<SelectListItem> UserRolesLoad(List<SelectListItem> model)
        {

            //check is role found in database or not
            var roles = roleManager.Roles;


            if (roles.Count() == 0)
            {
                model = new List<SelectListItem>()
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
                model = (from obj in roleManager.Roles
                         select new SelectListItem()
                         {
                             Value = obj.Id,
                             Text = obj.Name,

                         }).ToList();
            }
            return model;
        }

        
        [AcceptVerbs("Get","Post")]
        public IActionResult IsEmailInUse(string email)
        {
            ApplicationUser checkEmail = null;
            if (email != null) 
            { 
                checkEmail = userManager.Users.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
            }
            if(checkEmail==null)
            {
                return Json(true);
            }
            else
            {
                return Json($"The Email { email } You Enterd Is Duplicate");
            }


            
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

    }
}
