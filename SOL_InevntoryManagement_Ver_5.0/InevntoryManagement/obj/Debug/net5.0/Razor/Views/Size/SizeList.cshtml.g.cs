#pragma checksum "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7091b2006191360a0104b37306fb9f4f91e4f917"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Size_SizeList), @"mvc.1.0.view", @"/Views/Size/SizeList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using BussinessAccessLayer.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using DataAccessLayer.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using DataAccessLayer.Services.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Brands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Sources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Sizes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Measures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.GlobalFuntion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Purchase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using BussinessAccessLayer.ExtendModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\_ViewImports.cshtml"
using InevntoryManagement.ViewModels.Manufactures;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7091b2006191360a0104b37306fb9f4f91e4f917", @"/Views/Size/SizeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38317fe4f735627c15271726327f1d5a2ee9cabd", @"/_ViewImports.cshtml")]
    public class Views_Size_SizeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SizeListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Size", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-3 col-md-2 btn pull-right btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-xs btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/Pagination/_PaginationPage.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
  
    ViewBag.Title = "Size List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header bg-warning\">\r\n        <h2 class=\"card-title text-white\">Sources List</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7091b2006191360a0104b37306fb9f4f91e4f91711740", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"row my-2\">\r\n            <div class=\"col-sm-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7091b2006191360a0104b37306fb9f4f91e4f91712954", async() => {
                WriteLiteral("<span>Create <i class=\"mdi mdi-plus\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 19 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
         if (Model.sizeListModels != null && Model.sizeListModels.Count > 0)
        {
            int sl = Model.RowIndex;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row font-weight-bolder border py-2 bg-success"">
                <div class=""col-sm-3""><h4>SL No</h4></div>
                <div class=""col-sm-4""><h4>Size</h4></div>
                <div class=""col-sm-5""><h4>Action</h4></div>
            </div>
");
#nullable restore
#line 27 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
            foreach (var _model in Model.sizeListModels)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row border py-2 border-bottom\">\r\n                    <div class=\"col-sm-2\">");
#nullable restore
#line 30 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
                                     Write(sl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-sm-3\">");
#nullable restore
#line 31 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
                                     Write(_model.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-sm-3\">");
#nullable restore
#line 32 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
                                     Write(_model.sizeType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                    <div class=\"col-sm-4\">\r\n\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7091b2006191360a0104b37306fb9f4f91e4f91716631", async() => {
                WriteLiteral("<span>Edit <i class=\"mdi mdi-account-edit\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
                                                                             WriteLiteral(_model.SizeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n\r\n                                <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 1781, "\"", 1816, 2);
            WriteAttributeValue("", 1786, "deleteSizeButton", 1786, 16, true);
#nullable restore
#line 42 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
WriteAttributeValue("", 1802, _model.SizeId, 1802, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1817, "\"", 1853, 3);
            WriteAttributeValue("", 1827, "showButton(", 1827, 11, true);
#nullable restore
#line 42 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
WriteAttributeValue("", 1838, _model.SizeId, 1838, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1852, ")", 1852, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-xs btn-outline-danger\"><span>Delete <i class=\"mdi mdi-delete\"></i></span></button>\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n");
            WriteLiteral("                        <div class=\"row mt-3\"");
            BeginWriteAttribute("id", " id=\"", 2150, "\"", 2186, 2);
            WriteAttributeValue("", 2155, "showDeleteSizeDiv", 2155, 17, true);
#nullable restore
#line 48 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
WriteAttributeValue("", 2172, _model.SizeId, 2172, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\">\r\n                            <div class=\"col-sm-12\">\r\n                                <h4>Do You Want To Delete <strong>\'");
#nullable restore
#line 50 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
                                                              Write(_model.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'</strong></h4>\r\n\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-sm-6 mb-1 mb-md-0\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7091b2006191360a0104b37306fb9f4f91e4f91721696", async() => {
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn-block btn btn-xs btn-outline-danger\"><span>Yes <i class=\"mdi mdi-delete\"></i></span></button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
                                                                                                        WriteLiteral(_model.SizeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n\r\n                                    <div class=\"col-sm-6\">\r\n                                        <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 3012, "\"", 3049, 2);
            WriteAttributeValue("", 3017, "cancelDeleteSource", 3017, 18, true);
#nullable restore
#line 60 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
WriteAttributeValue("", 3035, _model.SizeId, 3035, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3050, "\"", 3088, 3);
            WriteAttributeValue("", 3060, "CancelDelete(", 3060, 13, true);
#nullable restore
#line 60 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
WriteAttributeValue("", 3073, _model.SizeId, 3073, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3087, ")", 3087, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn-block btn btn-xs btn-outline-secondary""><span>No <i class=""mdi mdi-arrow-left-bold""></i></span></button>
                                    </div>
                                </div>
                            </div>
                        </div>




                    </div>
                </div>
");
#nullable restore
#line 71 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
                sl = sl + 1;
            }

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-sm-12\">\r\n                    <h4 class=\"card-title\">No Size Is Available</h4>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 82 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7091b2006191360a0104b37306fb9f4f91e4f91727056", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 85 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Size\SizeList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n    <div class=\"card-footer\">\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    function showButton(id)
    {
        $(""#showDeleteSizeDiv"" + id).css(""display"", ""block"");
        $(""#deleteSizeButton"" + id).prop(""disabled"", true);
        }

        function CancelDelete(id) {
            $(""#showDeleteSizeDiv"" + id).css(""display"", ""none"");
            $(""#deleteSizeButton"" + id).prop(""disabled"", false);
        }
    </script>)

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SizeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
