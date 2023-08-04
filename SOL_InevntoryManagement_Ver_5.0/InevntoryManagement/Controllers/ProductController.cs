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
using System.Text;
using InevntoryManagement.ViewModels.Purchase;

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
                                    orderby obj.ModelName
                                    select new SelectListItem()
                                    {
                                        Text = obj.ModelName,
                                        Value = obj.Id.ToString(),
                                        Selected = _model.Id == obj.Id
                                    }
                                    ).ToList();

                    model.Brands = (from obj in unitOfWork.Brands.Get()
                                    orderby obj.BrandName
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
                                orderby obj.CType
                                select new SelectListItem
                                {
                                    Text = obj.CType,
                                    Value = obj.Id.ToString(),
                                    Selected = model.CategoryId != 0 ? model.CategoryId == obj.Id : false

                                }).ToList();



            model.Vendors = (from obj in unitOfWork.Vendors.Get()
                             orderby obj.VendorName
                             select new SelectListItem
                             {
                                 Text = obj.VendorName.ToUpper(),
                                 Value = obj.VendorName.ToUpper(),
                                 Selected = model.Vendor != null ? model.Vendor.ToUpper() == obj.VendorName.ToUpper() : false
                             }).ToList();

            model.Manufactures = (from obj in unitOfWork.Manufactures.Get()
                                  orderby obj.ManufactureName
                                  select new SelectListItem
                                  {
                                      Text = obj.ManufactureName.ToUpper(),
                                      Value = obj.ManufactureName.ToUpper(),
                                      Selected = model.Manufacture != null ? model.Manufacture.ToUpper() == obj.ManufactureName.ToUpper() : false

                                  }).ToList();

            model.Bins = (from obj in unitOfWork.Bins.Get()
                          orderby obj.BinNo
                          select new SelectListItem
                          {
                              Text = obj.BinNo,
                              Value = obj.BinNo.ToUpper(),
                              Selected = model.Bin != null ? model.Bin.ToUpper() == obj.BinNo.ToUpper() : false

                          }).ToList();

            model.Colors = (from obj in unitOfWork.Colors.Get()
                            orderby obj.ColorName
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
                           orderby obj.ProductSize
                           select new SelectListItem
                           {
                               Text = obj.ProductSize,
                               Value = obj.ProductSize,
                               Selected = model.Size != null ? (model.Size[0].ToUpper() == obj.ProductSize.ToUpper() && model.SizeType == obj.SizeType.ToString()) : false
                           }).ToList();
            
            model.Measurements = (from obj in unitOfWork.Measures.Get()
                           orderby obj.Measurements
                           select new SelectListItem
                           {
                               Text = obj.Measurements,
                               Value = obj.Measurements,
                               Selected = model.Measurement != null ? model.Measurement.ToUpper() == obj.Measurements.ToUpper() : obj.Measurements.ToUpper() == "KG".ToUpper()

                           }).ToList();

            model.Sources = (from obj in unitOfWork.Sources.Get()
                                  orderby obj.SourceName
                                  select new SelectListItem
                                  {
                                      Text = obj.SourceName,
                                      Value = obj.SourceName,
                                      Selected = model.Source != null ? model.Source.ToUpper() == obj.SourceName.ToUpper() :false

                                  }).ToList();

            return model;
        }




        [HttpPost]
        public IActionResult Create(ProductCreateViewModel model)
        {

            model = MultiSelecListItemLoad(model);

            if (ModelState.IsValid)
            {




              
                        bool chkDuplicate = false;
                string errsize = ""; // store the model size if find duplicate into the database
                    foreach (string _size in model.Size)
                    {
                        // checked into data base that Duplicate Found or Not
                        var prod = unitOfWork.Products.Get().Where(x=>x.Code.ToLower()==model.Code.ToLower() && x.Size.ToLower()==_size.ToLower()).FirstOrDefault();
                        if (prod != null)
                        {
                            ModelState.AddModelError("", $"{_size } is Duplicate");
                            chkDuplicate = true;
                        errsize = errsize=="" ? _size : errsize + "; " + _size;
                        }
                        
                      

                    }
                    if (chkDuplicate)
                    {
                        Global_Functions.SetMessage($"Prodcut Can Not Insert For The Model { errsize } because you have already insert this model with smae size Pleas Check The Model Is Duplicate Or Not","danger");
                        return View(model);
                    }
                
                




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

                List<Product> productList = new List<Product>();
            foreach(string _size in model.Size)
                {
                var product = new Product()
                {
                    Code = model.Code,
                    Description = model.Description,
                    ModelId = model.ModelId,
                    Color = model.Color,
                    Size = _size,
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
                    DiscountPrice = model.DiscountPrice,
                     Measurement= model.Measurement!=null ? model.Measurement.ToUpper() : "PCS",
                      Source=model.Source!=null ? model.Source.ToUpper() : "Local Market".ToLower(),
                       Pipeline=model.Pipeline
                     
                };

                    productList.Add(product);
                }





                unitOfWork.Products.Insert(productList);
                Global_Functions.SetMessage("Product Created Successfully", "success");
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
        public IActionResult ProductList(int? pagenumber, int? PageSize, string SearchText = null)
        {

            List<ProductListViewModel> productlist = GetProductListViewLoadedFromDatabas();

            int pagesize = PageSize ?? 4 ;
            
            
            if (SearchText != null)
            {
                pagenumber = 1;
                productlist = GetProductListViewLoadedFromDatabas().Where(x => x.Code.ToUpper().Contains(SearchText.ToUpper()) || x.Description.ToUpper().Contains(SearchText.ToUpper()) || x.Category.ToUpper().Contains(SearchText.ToUpper())).ToList();

            };

            var porduct = PaginatedList<ProductListViewModel>.Create(productlist.ToList(), pagenumber ?? 1 , pagesize);
            
            porduct.SearchText = SearchText;
                        
            List<SelectListItem> rowsize = new List<SelectListItem>()
            { new SelectListItem(){
                 Value="3",
                  Text="3",
                  Selected=pagesize==3 ? true :false 
            },

                  new SelectListItem(){
                 Value="4",
                  Text="4",
                  Selected=pagesize==4 ? true :false
            },
                 new SelectListItem(){
                 Value="5",
                  Text="5",
                  Selected=pagesize==5 ? true :false
            },

                 new SelectListItem(){
                 Value="10",
                  Text="10",
                  Selected=pagesize==10 ? true :false
            },

                 new SelectListItem(){
                 Value="25",
                  Text="25",
                  Selected=pagesize==25 ? true :false
            },

            };

            ViewBag.rowSize = rowsize;


            return View(porduct);
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
                 Source=result.Source,
                  Measurement=result.Measurement,
                   Pipeline=result.Pipeline //Order Pipeline
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
                                         
            var result = unitOfWork.Products.GetByID(model.Id);

            if (result == null)
            {
                ViewBag.ErrorTitle = "Product Edit Page Not Found";
                ViewBag.ErrorMessage = $"The Product Id { model.Id } You Are Looking for Not Found";
                return View();
            }
            else
            {


                //
                Product HasProduct = unitOfWork.Products.Get().Where(x => x.Code.ToUpper() == model.Code.ToUpper() && x.Size == model.Size).FirstOrDefault();


                if (HasProduct == null ||  (HasProduct!=null && result.Id == HasProduct.Id))
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
                    result.Measurement = model.Measurement != null ? model.Measurement.ToUpper() : "PCS";
                    result.Source = model.Source != null ? model.Source.ToUpper() : "Local Market".ToUpper();
                    result.Pipeline = model.Pipeline;

                    if (model.Photo != null)
                    {
                        if (model.ExistingPhotoPath != null && model.ExistingPhotoPath != "")
                        {
                            string fullpath = Path.Combine(_iWebHostEnvironment.WebRootPath, ImagePath.GetProductImagePath(model.ExistingPhotoPath));
                            System.IO.File.Delete(fullpath);

                        }

                        string upload_photo_path = Upload_Get_UniqueFileName(model);
                        result.PhotoPath = upload_photo_path;
                        model.ExistingPhotoPath = upload_photo_path;

                    }

                    try
                    {
                        unitOfWork.Products.Update(result);
                        Global_Functions.SetMessage("Product Update Successfully", "success");
                    }
                    catch (Exception ex)
                    {
                        ViewBag.ErrorTitle = "Product Update Error";
                        ViewBag.ErrorMessage = ex.Message;
                        return View("NotFound");
                    }
                }
                else
                {
                    Global_Functions.SetMessage($" {Global_Functions.DuplicateErrorMessage("Product")}. The Product Is Found Into Database with Same Code '{ model.Code }' And Same Size '{model.Size}' ", "danger");
                    return View(model);
                }



                } //end of else part
            }



            return View(model);
        }




        //Load Into DataTable By Call With Ajax Call Jquery
        [HttpGet]
        public JsonResult LoadDataTable()
        {
            List<ProductListViewModel> output = GetProductListViewLoadedFromDatabas();

            string o = JsonConvert.SerializeObject(output);

            DataTable dataTables = JsonConvert.DeserializeObject<DataTable>(o);

            return new JsonResult(new { dataTables });

        }

        //ProductListData Retirved from Database
        List<ProductListViewModel> GetProductListViewLoadedFromDatabas()
        {
            return (from cats in unitOfWork.Categories.Get()
                    join brands in unitOfWork.Brands.Get()
                    on cats.Id equals brands.CategoryId
                    join models in unitOfWork.Models.Get()
                    on brands.Id equals models.BrandId
                    join products in unitOfWork.Products.Get()
                    on models.Id equals products.ModelId into egroups
                    from products in egroups
                    orderby products.Description
                    select new ProductListViewModel()
                    {
                        Id = products.Id,
                        BrandName = brands.BrandName,
                        Category = cats.CType,
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
                         Measurement=products.Measurement,
                        Source = products.Source,
                        Pipeline = products.Pipeline,

                    }).ToList();
        }



        //Call from Jquery Ajax Product Form
        [HttpGet]
        public JsonResult FindBrandByCategoryId(int catid)
        {
            var output = unitOfWork.Brands.Get().Where(x => x.CategoryId == catid).ToList().OrderBy(x => x.BrandName);
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
            var output = unitOfWork.Models.Get().Where(x => x.BrandId == brandid).ToList().OrderBy(x=>x.ModelName);
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



        //call from create purchase form input name code autocomplete
        [HttpGet]
        public JsonResult FindProduct(string term, string searchField)
        {
            List<Autocomplete> output = null;


            if(term!=null && term != "")
            {
                output=(from cats in unitOfWork.Categories.Get()
                 join brands in unitOfWork.Brands.Get()
                 on cats.Id equals brands.CategoryId
                 join models in unitOfWork.Models.Get()
                 on brands.Id equals models.BrandId
                 join products in unitOfWork.Products.Get()
                 on models.Id equals products.ModelId into egroups
                 from products in egroups
                 orderby products.Description
                 select new Autocomplete()
                 {
                     code = products.Code,
                     value = products.Id.ToString(),
                     description = products.Description,
                     color = products.Color,
                     model = models.ModelName,
                     id = products.Id.ToString(),
                     size = products.Size,
                      category=cats.CType,
                     photopath =products.PhotoPath

                 }).Where(x => searchField=="code"? x.code.ToLower().Contains(term.ToLower()): searchField=="model"? x.model.ToLower().Contains(term.ToLower()): x.description.ToLower().Contains(term.ToLower())).ToList();


                       
                        
            }

            //StringBuilder st = new StringBuilder();
            //st.Append("<table> </br>");
            //st.Append("<tbody> </br>");
            //st.Append("<tr> </br>");
            //foreach(string c in output)
            //{
            //    st.Append("<td>" + c + "</td>");
            //}

            //st.Append("</tr> </br>");
            //st.Append("</tbody>");
            //st.Append("</table>");

            return new JsonResult(new { output });
        }


    }
}
