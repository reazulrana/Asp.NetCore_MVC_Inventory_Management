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
using Newtonsoft.Json;
using System.Data;
namespace InevntoryManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IWebHostEnvironment _iWebHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment _hostingEnvironment)
        {

            this.unitOfWork = unitOfWork;
            this._iWebHostEnvironment = _hostingEnvironment;


        }


        [HttpGet]
        public IActionResult Create()
        {


            var model = new ProductCreateViewModel();

            try
            {
                model = MultiSelecListItemLoad(model);
            }
            catch (Exception ex)
            {

                ViewBag.ErrorTitle = ex.InnerException;
                ViewBag.ErrorMessage = ex.Message;
                return View("NotFound");
            }
            return View(model);

        }



        //categoru id and brandid retrived by model id
        ProductEditViewModel Retirved_CategoryId_and_BrandId(ProductEditViewModel model)
        {

            if (model.ModelId != 0)
            {
                Model _model = unitOfWork.Models.GetByID(model.ModelId);
                if (_model != null)
                {
                    model.Brandid = _model.BrandId; // its use for Get Category Load By retriving Catagory Id from _model.Brandid

                    model.Models = (from obj in unitOfWork.Models.Get().Where(x => x.BrandId == _model.BrandId)
                                    select new SelectListItem()
                                    {
                                        Text = obj.ModelName,
                                        Value = obj.Id.ToString(),
                                        Selected = _model.Id == obj.Id
                                    }
                                    ).ToList();

                    model.Brands = (from obj in unitOfWork.Brands.Get()
                                    select new SelectListItem()
                                    {
                                        Text = obj.BrandName,
                                        Value = obj.Id.ToString(),
                                        Selected = _model.BrandId == obj.Id
                                    }
                                    ).ToList();
                }
            }


            return model;

        }

        //load selectlistitem
        ProductCreateViewModel MultiSelecListItemLoad(ProductCreateViewModel model)
        {

            if (model.Brandid != 0)
            {
                Brand _brand = unitOfWork.Brands.GetByID(model.Brandid);
                if (_brand != null)
                {
                    model.CategoryId = _brand.CategoryId;
                }
            }

            model.Categories = (from obj in unitOfWork.Categories.Get()
                                select new SelectListItem
                                {
                                    Text = obj.CType,
                                    Value = obj.Id.ToString(),
                                    Selected = model.CategoryId != 0 ? model.CategoryId == obj.Id : false

                                }).ToList();



            model.Vendors = (from obj in unitOfWork.Vendors.Get()
                             select new SelectListItem
                             {
                                 Text = obj.VendorName.ToUpper(),
                                 Value = obj.VendorName.ToUpper(),
                                 Selected = model.Vendor != null ? model.Vendor.ToUpper() == obj.VendorName.ToUpper() : false
                             }).ToList();

            model.Manufactures = (from obj in unitOfWork.Manufactures.Get()
                                  select new SelectListItem
                                  {
                                      Text = obj.ManufactureName.ToUpper(),
                                      Value = obj.ManufactureName.ToUpper(),
                                      Selected = model.Manufacture != null ? model.Manufacture.ToUpper() == obj.ManufactureName.ToUpper() : false

                                  }).ToList();

            model.Bins = (from obj in unitOfWork.Bins.Get()
                          select new SelectListItem
                          {
                              Text = obj.BinNo,
                              Value = obj.BinNo.ToUpper(),
                              Selected = model.Bin != null ? model.Bin.ToUpper() == obj.BinNo.ToUpper() : false

                          }).ToList();

            model.Colors = (from obj in unitOfWork.Colors.Get()
                            select new SelectListItem
                            {
                                Text = obj.ColorName,
                                Value = obj.ColorName.ToUpper(),
                                Selected = model.Color != null ? model.Color.ToUpper() == obj.ColorName.ToUpper() : false

                            }).ToList();


            //model.Bins = (from obj in unitOfWork.Bins.Get()
            //                      select new SelectListItem
            //                      {
            //                          Text = obj.BinNo,
            //                          Value = obj.Id.ToString()
            //                      }).ToList();

            model.Sizes = (from obj in unitOfWork.Sizes.Get().Where(x=> x.SizeType.ToString()==model.SizeType)
                           select new SelectListItem
                           {
                               Text = obj.ProductSize,
                               Value = obj.ProductSize,
                               Selected = model.Size != null ? (model.Size.ToUpper() == obj.ProductSize.ToUpper() && model.SizeType == obj.SizeType.ToString()) : false

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
                if (err == true)
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
                var uploadfolder = Path.Combine(_iWebHostEnvironment.WebRootPath, ImagePath.GetProductImagePath());
                uniquefilename = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                var fullpath = Path.Combine(uploadfolder, uniquefilename);
                model.Photo.CopyTo(new FileStream(fullpath, FileMode.Create));
            }

            return uniquefilename;
        }

        [HttpGet]
        public IActionResult ProductList()
        {

            return View();
        }



        //edit section

        [HttpGet]
        public IActionResult Edit(int id)
        {


            var result = unitOfWork.Products.GetByID(id);

            if (result == null)
            {

                ViewBag.ErrorTitle = "Product Edit Page Not Found";
                ViewBag.ErrorMessage = $"The Product Id { id } You Are Looking for Not Found";
                return View();
            }

            ProductEditViewModel product = new ProductEditViewModel()
            {
                Bin = result.Bin,
                Code = result.Code,
                Color = result.Color,
                Description = result.Description,
                DiscountPrice = result.DiscountPrice,
                Id = result.Id,
                Manufacture = result.Manufacture,
                ModelId = result.ModelId,
                OpeningBalance = result.OpeningBalance,
                OpeningQty = result.OpeningQty,
                Remarks = result.Remarks,
                Size = result.Size,
                SizeType = result.SizeType,
                Unitprice = result.Unitprice,
                Vendor = result.Vendor,
            };
            string fullpath = Path.Combine(_iWebHostEnvironment.WebRootPath, ImagePath.GetProductImagePath(result.PhotoPath));
            bool isExist = System.IO.File.Exists(fullpath);
            product.ExistingPhotoPath = isExist == true ? result.PhotoPath : null;






            product = Retirved_CategoryId_and_BrandId(product);
            product = MultiSelecListItemLoad(product) as ProductEditViewModel;


            return View(product);
        }




        //Post Edit

        [HttpPost]
        public IActionResult Edit(ProductEditViewModel model)
        {



            model = Retirved_CategoryId_and_BrandId(model);
            model = MultiSelecListItemLoad(model) as ProductEditViewModel;

            


            if (ModelState.IsValid)
            {

                Product HasProduct = unitOfWork.Products.Get().Where(x => x.Code.ToUpper() == model.Code.ToUpper() && x.Size == model.Size).FirstOrDefault();
                
                if(HasProduct != null)
                {
                    
                    Global_Functions.SetMessage($" {Global_Functions.DuplicateErrorMessage("Product")}. The Product Is Found Into Database with Same Code '{ model.Code }' And Same Size '{model.Size}' ", "danger");

                    return View(model);
                }

                var result = unitOfWork.Products.GetByID(model.Id);

                if (result == null)
                {
                    ViewBag.ErrorTitle = "Product Edit Page Not Found";
                    ViewBag.ErrorMessage = $"The Product Id { model.Id } You Are Looking for Not Found";
                    return View();
                }
                else
                {
                    result.Bin = model.Bin;
                    result.Code = model.Code;
                    result.Color = model.Color;
                    result.Description = model.Description;
                    result.DiscountPrice = model.DiscountPrice;
                    result.Manufacture = model.Manufacture;
                    result.ModelId = model.ModelId;
                    result.OpeningBalance = model.OpeningBalance;
                    result.OpeningQty = model.OpeningQty;
                    result.Remarks = model.Remarks;
                    result.Size = model.Size;
                    result.SizeType = model.SizeType;
                    result.Unitprice = model.Unitprice;
                    result.Vendor = model.Vendor;


                    if(model.Photo!=null)
                    {
                        if(model.ExistingPhotoPath!=null && model.ExistingPhotoPath!="")
                        {
                            string fullpath = Path.Combine(_iWebHostEnvironment.WebRootPath, ImagePath.GetProductImagePath(model.ExistingPhotoPath));
                            System.IO.File.Delete(fullpath);

                        }
                        
                        string upload_photo_path= Upload_Get_UniqueFileName(model);
                        result.PhotoPath = upload_photo_path;
                        model.ExistingPhotoPath = upload_photo_path;

                    }

                    try { 
                    unitOfWork.Products.Update(result);
                        Global_Functions.SetMessage("Product Update Successfully", "success");
                    }
                    catch(Exception ex)
                    {
                        ViewBag.ErrorTitle = "Product Update Error";
                        ViewBag.ErrorMessage = ex.Message;
                        return View("NotFound");
                    }
                } //end of else part
            }



            return View(model);
        }




        //Load Into DataTable By Call With Ajax Call Jquery
        [HttpGet]
        public JsonResult LoadDataTable()
        {
            var output = (from cats in unitOfWork.Categories.Get()
                          join brands in unitOfWork.Brands.Get()
                          on cats.Id equals brands.CategoryId
                          join models in unitOfWork.Models.Get()
                          on brands.Id equals models.BrandId
                          join products in unitOfWork.Products.Get()
                          on models.Id equals products.ModelId into egroups
                          from products in egroups
                          select new ProductListViewModel()
                          {
                              Id = products.Id,
                              BrandName = brands.BrandName,
                               Category= cats.CType,
                              BinNo = products.Bin,
                              Code = products.Code,
                              Color = products.Color,
                              CreatedDate = products.CreatedDate,
                              Description = products.Description,
                              DiscountPrice = products.DiscountPrice,
                              ManufactureName = products.Manufacture,
                              ModelName = models.ModelName,
                              OpeningBalance = products.OpeningBalance,
                              OpeningQty = products.OpeningQty,
                              PhotoPath = products.PhotoPath,
                              Remarks = products.Remarks,
                              SizeName = products.Size,
                              SizeType = products.SizeType,
                              Unitprice = products.Unitprice,
                              VendorName = products.Vendor,
                          }).ToList();

            string o = JsonConvert.SerializeObject(output);

            DataTable dataTables = JsonConvert.DeserializeObject<DataTable>(o);

            return new JsonResult(new { dataTables });

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
