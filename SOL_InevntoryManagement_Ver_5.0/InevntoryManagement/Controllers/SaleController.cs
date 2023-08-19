using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.ViewModels.Sales;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InevntoryManagement.Controllers
{
    public class SaleController : Controller
    {
        private readonly IUnitOfWork unitofWork;

        public SaleController(IUnitOfWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Create()
        {
            SaleCreateViewModel model = new SaleCreateViewModel();
            model.BranchList = branchlist(model);
            return View(model);
        }


        private List<SelectListItem> branchlist(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitofWork.Branchs.Get()
                      select new SelectListItem()
                      {
                          Text = obj.Name,
                          Value = obj.Id.ToString(),
                          Selected = model.BranchId != 0 ? obj.Id == model.BranchId : false
                      }).ToList();

            return output;
        }
    }
}
