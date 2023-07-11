using InevntoryManagement.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessAccessLayer.Model;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using InevntoryManagement.GlobalFuntion;

namespace InevntoryManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHostingEnvironment hostingEnvironment;

        public ProductController(IUnitOfWork unitOfWork,IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }

        
        [HttpGet]
        public IActionResult Create()
        {

            var model = new ProductCreateViewModel();
            model= MultiSelecListItemLoad(model);

            return View(model);
            

        }


        ProductCreateViewModel MultiSelecListItemLoad(ProductCreateViewModel model)
        {
            model.Categories = (from obj in unitOfWork.Categories.Get()
                                select new SelectListItem
                                {
                                    Text = obj.CType,
                                    Value = obj.Id.ToString()
                                }).ToList();



            model.Vendors = (from obj in unitOfWork.Vendors.Get()
                                select new SelectListItem
                                {
                                    Text = obj.VendorName,
                                    Value = obj.Id.ToString()
                                }).ToList();

            model.Manufactures = (from obj in unitOfWork.Manufactures.Get()
                                select new SelectListItem
                                {
                                    Text = obj.ManufactureName,
                                    Value = obj.Id.ToString()
                                }).ToList();


            //model.Bins = (from obj in unitOfWork.Bins.Get()
            //                      select new SelectListItem
            //                      {
            //                          Text = obj.BinNo,
            //                          Value = obj.Id.ToString()
            //                      }).ToList();

            model.Sizes = (from obj in unitOfWork.Sizes.Get()
                          select new SelectListItem
                          {
                              Text = obj.ProductSize,
                              Value = obj.Id.ToString()
                          }).ToList();




            return model;
        }




        [HttpPost]
        public IActionResult Create(ProductCreateViewModel model)
        {

            model = MultiSelecListItemLoad(model);

            if (ModelState.IsValid)
            {

                bool err = false;
                //if (model.Color == "-1")
                //{

                //    ModelState.AddModelError("", "Color Field Not Selected");
                //    err = true;
                //}

                //if (model.Size == "-1")
                //{

                //    ModelState.AddModelError("", "Color Field Is Required");
                //    err = true;
                //}

                if (model.Vendor == "-1")
                {

                    ModelState.AddModelError("", "Vendor Field Is Required");
                    err = true;
                }


                if (model.Manufacture == "-1")
                {

                    ModelState.AddModelError("", "Manufacture Field Is Required");
                    err = true;
                }

                if (model.Bin == "-1")
                {

                    ModelState.AddModelError("", "Bin Field Is Required");
                    err = true;
                }
                if(err==true)
                {
                    return View(model);

                }

                string uniquefilename = Upload_Get_UniqueFileName(model);

                var product = new Product()
                {
                    Code = model.Code,
                    Description = model.Description,
                    ModelId = model.ModelId,
                    Color = model.Color,
                    Size = model.Size,
                    SizeType = model.SizeType,
                    Unitprice = model.Unitprice,
                    OpeningBalance = model.OpeningBalance,
                    OpeningQty = model.OpeningQty,
                    CreatedDate = DateTime.Now.Date,
                    Vendor = model.Vendor,
                    Manufacture = model.Manufacture,
                    Bin = model.Bin,
                    PhotoPath = uniquefilename,
                    Remarks = model.Remarks,
                    DiscountPrice = model.DiscountPrice
                };


                unitOfWork.Products.Insert(product);
                Global_Functions.SetMessage("Product Created Successfully", "suceess");
                return View(model);

            }

            return View(model);

        }



        string Upload_Get_UniqueFileName(ProductCreateViewModel model)
        {
            string uniquefilename = null;
            if (model.Photo != null)
            {
                var uploadfolder = Path.Combine(hostingEnvironment.WebRootPath, "Projects/Images/Product");
                uniquefilename = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                var fullpath = Path.Combine(uploadfolder, uniquefilename);
                model.Photo.CopyTo(new FileStream(fullpath, FileMode.Create));
            }

            return uniquefilename;
        }







        [HttpGet]
        public JsonResult FindBrandByCategoryId(int catid)
        {
            var output = unitOfWork.Brands.Get().Where(x => x.CategoryId == catid).ToList();
            bool success = false;
            if (output != null)
            {
                success = true;
            }
            return new JsonResult(new { output, success });
        }



        [HttpGet]
        public JsonResult FindModelByBrandID(int brandid)
        {
            var output = unitOfWork.Models.Get().Where(x => x.BrandId == brandid).ToList();
            bool success = false;
            if (output != null)
            {
                success = true;
            }
            return new JsonResult(new { output, success });
        }



        [HttpGet]
        public JsonResult FindSizeByID(int id)
        {
            var output = unitOfWork.Sizes.Get().Where(x => x.SizeType == id).ToList();
            bool success = false;
            if (output != null)
            {
                success = true;
            }
            return new JsonResult(new { output, success });
        }


    }
}
