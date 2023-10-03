using BussinessAccessLayer.Model;
using DataAccessLayer.Services.Interface;
using InevntoryManagement.GlobalFuntion;
using InevntoryManagement.ViewModels.Sizes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.Controllers
{
    public class SizeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SizeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult SizeList(int? pageno,int? pagesize)
        {
            SizeListViewModel output = new SizeListViewModel();

            output.sizeListModels= (from obj in unitOfWork.Sizes.Get()
                         select new SizeListModel()
                         {
                             SizeId = obj.Id,
                             SizeName = obj.ProductSize,
                             sizeType = obj.SizeType == 1 ? "Size" : "Dimension"
                         }).OrderByDescending(x=>x.SizeName).ToList(); ;
            output.TotalRow = output.sizeListModels.Count();
            output.PageSize = output.DefaultPageSize(pagesize);
            output.PageIndex = output.DefaultPageIndex(pageno);


            output.sizeListModels = output.sizeListModels.Skip(output.SkipRow).Take(output.PageSize).OrderBy(x => x.sizeType).OrderBy(x=>x.SizeName).ToList();


            return View(output);
        }



        //Create Section

        [HttpGet]
        public IActionResult Create()
        {
            SizeCreateViewModel model = new SizeCreateViewModel();
            model.Types = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                     Text="Size",
                     Value="1",
                },
                new SelectListItem()
                {
                     Text="Dimension",
                     Value="2",
                     Selected=false
                },
                new SelectListItem()
                {
                     Text="Select Type",
                     Value="-1",
                     Selected=true
                }

            };

            return View(model);
        }



        [HttpPost]
        public IActionResult Create(SizeCreateViewModel model)
        {

            model.Types = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                     Text="Size",
                     Value="1",
                },
                new SelectListItem()
                {
                     Text="Dimension",
                     Value="2",
                     Selected=false
                },
                new SelectListItem()
                {
                     Text="Select Type",
                     Value="-1",
                     Selected=true
                }

            };

            if (model.Type == -1)
            {
                Global_Functions.SetMessage("Please Select Dimension Or Size", "danger");

                return View(model);
            }

            if (ModelState.IsValid)
            {

                string strSize = model.Type == 1 ? "Size" : "Dimension";
                if (model.IsSelected)
                {
                    clear_IsSelected_Size(); //Clear All IsSelected Field in Size Table From Database

                }
                Size size = new Size()
                {
                    ProductSize = model.Size,
                    SizeType = model.Type,
                     IsSelected=model.IsSelected
                     

                };

                unitOfWork.Sizes.Insert(size);
                Global_Functions.SetMessage($"Size '{ model.Size }' & Type '{strSize}' Create Successfully", "success");

                return View(model);





            }

            return View(model);
        }






        // Call from ajax 

        [HttpPost]
        public JsonResult Create_Size_With_Ajax(string size,int sizetype)
        {
            string msg = "";

            bool success = false;
            Size output = new Size();
            try
            {

                var category = unitOfWork.Sizes.Get().Where(x => x.ProductSize.ToLower() == size.ToLower() && x.SizeType==sizetype).FirstOrDefault();

                //Category Exist
                if (category != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Size");

                }
                else
                {
                    output.ProductSize = size.ToUpper();
                    output.SizeType = sizetype;
                    //output.IsSelected = IsSelected
                    unitOfWork.Sizes.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Size");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Size");
            }
            return new JsonResult(new { output, success, msg });


        }









        //Edit Sectoon
        [HttpGet]
        public IActionResult Edit(int id)
        {

            var result = unitOfWork.Sizes.GetByID(id);

            if (result == null)
            {
                ViewBag.ErrorTitle = "Size Edit Page Not Found";
                ViewBag.ErrorMessage = $"Id {id} You Enterd Is Not Found";
                return View("NotFound");

            }
            else
            {
                SizeEditViewModel model = new SizeEditViewModel()
                {
                    SizeId = result.Id,
                    Size = result.ProductSize,
                    Type = result.SizeType,
                     IsSelected=result.IsSelected,
                    Types = new List<SelectListItem>()
                     {
                         new SelectListItem()
                         {
                               Text="Size",
                               Value="1",
                               Selected=result.SizeType==1
                         },
                         new SelectListItem()
                {
                     Text="Dimension",
                     Value="2",
                     Selected=result.SizeType==2
                },
                new SelectListItem()
                {
                     Text="Select Type",
                     Value="-1",
                     Selected=result.SizeType==-1
                }
                     }

                };

                return View(model);

            }


        }





        [HttpPost]
        public IActionResult Edit(SizeEditViewModel model)
        {




            if(ModelState.IsValid)
            {
                var result = unitOfWork.Sizes.GetByID(model.SizeId);
               string strsize = result.ProductSize;
                if (result == null)
                {
                    ViewBag.ErrorTitle = "Size Edit Page Not Found";
                    ViewBag.ErrorMessage = $"Id {model.SizeId} You Enterd Is Not Found";
                    return View("NotFound");

                }


                else
                {
                    if (model.IsSelected)
                    {
                        clear_IsSelected_Size(); //Clear All IsSelected Field in Size Table From Database

                    }

                    result.ProductSize = model.Size;
                    result.SizeType = model.Type;
                    result.IsSelected = model.IsSelected;
                    unitOfWork.Sizes.Update(result);
                    Global_Functions.SetMessage($"Size Update Successfully from { strsize } To {model.Size }", "success");
                    return RedirectToAction("SizeList", "Size");


                    model.Types = new List<SelectListItem>()
                    {


                         new SelectListItem()
                         {
                               Text="Size",
                               Value="1",
                               Selected=result.SizeType==1
                         },
                         new SelectListItem()
                {
                     Text="Dimension",
                     Value="2",
                     Selected=result.SizeType==2
                },
                new SelectListItem()
                {
                     Text="Select Type",
                     Value="-1",
                     Selected=result.SizeType==-1
                }
                     };

                    

                    return View(model);

                }


            }








            return View();
        }

        //Clear All IsSelected Field in Size Table From Database
        private void clear_IsSelected_Size()
        {
            List<Size> sizes = unitOfWork.Sizes.Get().ToList();

            foreach (var size in sizes)
            {
                var _size = unitOfWork.Sizes.GetByID(size.Id);
                _size.IsSelected = false;
                unitOfWork.Sizes.Update(_size);
            }

        }





        //Delete Section 
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if(ModelState.IsValid)
            {
                var model = unitOfWork.Sizes.GetByID(id);

                if (model == null)
                {
                    ViewBag.ErrorTitle = "Size Edit Page Not Found";
                    ViewBag.ErrorMessage = $"Id {id} You Enterd Is Not Found";
                    return View("NotFound");
                }else
                {

                    unitOfWork.Sizes.Delete(model);
                    Global_Functions.SetMessage($"Product Size Delete Successfully '{ model.ProductSize }' ", "success");
                    return RedirectToAction("SizeList", "Size");

                }

               
            }

            return View();
        }


        //Find For Duplicate Size
        [AcceptVerbs("Get", "Post")]
        public IActionResult FindSize(string Size)
        {
            if (!string.IsNullOrEmpty(Size))
            {
                var result = unitOfWork.Sizes.Get().Where(x => x.ProductSize.ToLower() == Size.ToLower()).FirstOrDefault();

                if (result == null)
                {
                    return Json(true);

                }
                else
                {
                    return Json($" The Category You Enter Is Duplicate {Size}");


                }

            }

            return View();
        }


    }
}
