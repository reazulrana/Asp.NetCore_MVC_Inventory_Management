#pragma checksum "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210b98833f17cec0f1bf5c6a8d018add3d1d520a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_Edit), @"mvc.1.0.view", @"/Views/Purchase/Edit.cshtml")]
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
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210b98833f17cec0f1bf5c6a8d018add3d1d520a", @"/Views/Purchase/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"690000e0c2bf0b582bb5a7a8ef47e4fbeb661085", @"/_ViewImports.cshtml")]
    public class Views_Purchase_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurchaseEditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListPurchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info col-md-3 btn-xs float-md-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/DuplicateModelShow.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\Edit.cshtml"
  
    ViewBag.Title = "Edit Purchase";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n\r\n    .divAutocomplete table tbody tr:hover {\r\n        color: white;\r\n        background-color: black\r\n    }\r\n\r\n    .purchaseno {\r\n        background-color: lightgray !important;\r\n        color: white;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210b98833f17cec0f1bf5c6a8d018add3d1d520a11652", async() => {
                WriteLiteral("\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            <h3 class=\"card-title text-white\">Create Purchase</h3>\r\n        </div>\r\n        <div class=\"card-body\">\r\n");
                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210b98833f17cec0f1bf5c6a8d018add3d1d520a12240", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "210b98833f17cec0f1bf5c6a8d018add3d1d520a13989", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"



            <div class=""col-md-12 border mb-2"">
                <div class=""row"">
                    <div class=""col-md-12 pl-2 bg-dark"">
                        <h5 class=""card-title p-2 text-white"">Purchase Information</h5>
                    </div>
                </div>
                    
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "210b98833f17cec0f1bf5c6a8d018add3d1d520a15500", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 44 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 46 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\Edit.cshtml"
           Write(Html.Partial("~/Views/Shared/Purchase/_PurcchaseDetails.cshtml", Model));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>

            <div class=""border col-md-12 mb-2"">
                <div class=""row"">
                    <div class=""col-md-12 pl-2 bg-dark"">
                        <h5 class=""card-title text-white p-2"">Product Information</h5>
                    </div>
                </div>

                ");
#nullable restore
#line 56 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\Edit.cshtml"
           Write(Html.Partial("~/Views/Shared/Purchase/_PurchaseEditProductDetails.cshtml",Model));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>

            <div class=""col-md-12 border mb-2"">
                <div class=""row"">
                    <div class=""col-md-12 pl-2 bg-dark mb-2"">
                        <h5 class=""card-title p-2 text-white"">Costing Information</h5>
                    </div>
                </div>

                ");
#nullable restore
#line 66 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\Edit.cshtml"
           Write(Html.Partial("~/Views/Shared/Purchase/_PurchasePriceDetails.cshtml", Model));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>


        </div>
        <div class=""card-footer"">
            <div class=""form-group"">
                <button class=""btn btn-facebook col-md-3 btn-xs"">Update<span class=""pl-2""><i class=""ml-1 mdi mdi-pencil""></i></span></button>

                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210b98833f17cec0f1bf5c6a8d018add3d1d520a19464", async() => {
                    WriteLiteral("List<span class=\"pl-2\"><i class=\"mdi mdi-view-list\"></i></span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210b98833f17cec0f1bf5c6a8d018add3d1d520a22795", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>

        //const { table } = require(""console"");

        $(document).ready(function () {


            onloadPage()
            function onloadPage()
            {
                $(""#Invoice"").attr(""disabled"", ""disabled"");
                $(""#Invoice"").addClass(""..purchaseno"");
            }

            $(""#PaymentOnCash"").change(function () {
                let amountbill = amountclass()
                $(""#Dues"").val((amountbill.TotalAmount - amountbill.PaymentOnCash))



            });
            $(""#Discount"").change(function()
            {
                let amountbill = amountclass()
                $(""#NetAmount"").val((amountbill.GrossAmount - amountbill.Discount))


            })

            $(""#Transport"").change(function () {
                let amountbill = amountclass()
                let totalbill = 0

                totalbill = parseInt((parseInt(amountbill.TotalAmount) + parseInt(amountbill.Transport) + parseInt(amountbill.Others)))
                WriteLiteral(@"
                $(""#GrossAmount"").val(totalbill)
                $(""#NetAmount"").val(totalbill)
            })

            $(""#Others"").change(function () {
                let amountbill = amountclass()
                let totalbill =0

                totalbill = parseInt((parseInt(amountbill.TotalAmount) + parseInt(amountbill.Transport) + parseInt(amountbill.Others)))
                $(""#GrossAmount"").val(totalbill)
                $(""#NetAmount"").val(totalbill)

            })


            function ClearField()
            {
                $(""#txtsearchfield"").val('')
                $(""#txtProductId"").val('')
                $(""#txtProductCode"").val('')
                $(""#txtProductDescription"").val('')

                $(""#txtProductModel"").val('')
                $(""#txtProductSize"").val('')
                $(""#txtProductColor"").val('')
                $("".pimage"").attr(""src"", '')
                $(""#txtImage"").val('')
               $(""#txtProductQty"").val('0')
       ");
                WriteLiteral(@"        $(""#txtProductPurchasePrice"").val('0')
               $(""#txtProductTotalAmount"").val('0')
            }

            function amountclass()
            {
                let _amount = {
                    TotalAmount: $(""#TotalAmount"").val(),
                    PaymentOnCash: $(""#PaymentOnCash"").val(),
                    Dues: $(""#Dues"").val(),
                    Transport: $(""#Transport"").val(),
                    Others: $(""#Others"").val(),
                    GrossAmount: $(""#GrossAmount"").val(),
                    Discount: $(""#Discount"").val(),
                    NetAmount: $(""#NetAmount"").val(),
                    PaymentTypeId: $(""#PaymentTypeId"").val(),


                }

                return _amount
            }


            //clear all product field
            $(""#btnClearProduct"").click(function () {


            })



            //calculate total product purchage price amount
            function calculatePurchageProduct()
            {
");
                WriteLiteral(@"                let tr = $(""#productlist tr"")
                $(""#TotalAmount"").val('0')
                if ($(tr).length > 0) {
                    var amount = 0;
                    $(tr).each(function (i, item) {
                        amount = (amount + parseInt($(this).find(""td:last"").prev().text()));
                    })
                    $(""#TotalAmount"").val(amount) //product cost


                    let _amountclass = amountclass();

                    let grossamount = (parseInt(_amountclass.TotalAmount) + parseInt(_amountclass.Transport) + parseInt(_amountclass.Others))
                    let netamount = (grossamount - parseInt(_amountclass.Discount))
                    $(""#GrossAmount"").val(grossamount)
                    $(""#NetAmount"").val(netamount)
                    $(""#Dues"").val(parseInt(_amountclass.TotalAmount) - parseInt(_amountclass.PaymentOnCash))
                }

            }


        

            //btnAddPaymentType
            $(""#btnAddPay");
                WriteLiteral(@"mentType"").click(function () {
                $(""#divPaymentType"").toggle()

            })


        /*$('#TrDate').datepicker();*/
        //$(""#productlist tr"").dblclick(function () {
        //    var id = product();

        //    alert(id.Code);
        //})

        //product add to prodcut list tabel
        $(""#btnAddProduct"").click(function () {

            var _product = product();
            if (_product.TotalAmount == """" || _product.TotalAmount == ""0"" || _product.TotalAmount == isNaN)
            {
                alert(""Total Price is '0'"");
                return;
            }
            append_New_Row();
        })

        //calculate Total Price with qty change
        $(""#txtProductQty"").focus(function ()
        {
            var val = $(this).val();
            if (isNaN(val))
            {
                $(this).val('0');
            }



        })

        $(""#txtProductQty"").focusout(function () {
            var qty = $(this).val()
      ");
                WriteLiteral(@"      var price = $('#txtProductPurchasePrice').val()

            var totalprice = qty * price;
            if (isNaN(totalprice)) {
                alert(""Qty Is Not Number Please Type Number"")
                $(this).focus();
            }

            $('#txtProductTotalAmount').val(qty * price);
        })

        //calculate Total Price with price change
            $(""#txtProductPurchasePrice"").focus(function () {
            var val = $(this).val();
            if (isNaN(val)) {
                $(this).val('0');
            }



        })

        $(""#txtProductPurchasePrice"").focusout(function () {
            var qty = $(this).val()
            var price = $('#txtProductQty').val()

            var totalprice = qty * price;
            if (isNaN(totalprice)) {
                alert(""Purchase Is Not Number Please Type Number"")
                $(this).focus();
            }

            $('#txtProductTotalAmount').val(qty * price);
        })



        function ");
                WriteLiteral(@"product() {
            var _product = {
                ProductId: $(""#txtProductId"").val(),
                Image: $(""#txtImage"").val(),
                Code: $(""#txtProductCode"").val(),
                Description: $(""#txtProductDescription"").val(),
                Model: $(""#txtProductModel"").val(),
                Size: $(""#txtProductSize"").val(),
                Color: $(""#txtProductColor"").val(),
                Qty: $(""#txtProductQty"").val(),
                PurchasePrice: $(""#txtProductPurchasePrice"").val(),
                TotalAmount: $(""#txtProductTotalAmount"").val(),
            }
            return _product
        }




            //tr Remove from product table By Delete Button click
            $(""#productlist"").on(""click"", ""button"", function () {

                if(confirm(""Do You Want to Remove Row""))
                {
                $(this).closest(""tr"").remove();
                    calculatePurchageProduct();
                }
            })

        functi");
                WriteLiteral(@"on append_New_Row()
        {

            var LastSl = $('#productlist tr').length + 1;
            var p = product();
            let _photopath = (p.Image == """" || p.Image == null) ? ""/Projects/Images/DefaultImage/No_Image_Available.jpg"" : ""/Projects/Images/Product/"" + p.Image

            var sl = '<td><input hidden name=""ProductIds"" type=""text"" value=""' + p.ProductId + '""/>' + LastSl + '</td>';
            var Image = '<td> <input hidden name=""Images"" value=""' + p.Image + '"" />  <img src = ""' + _photopath + '"" height = 90 width = 90 /> </td > ';
            var Code = '<td> <input hidden name=""Codes"" value=""' + p.Code + '"" />' + p.Code + '</td>';
            var Description = '<td><input hidden name=""Descriptions"" value=""' + p.Description + '"" />' + p.Description + '</td>';
            var Model = '<td><input hidden name=""Models"" value=""' + p.Model + '"" />' + p.Model + '</td>';
            var Size = '<td><input hidden name=""Sizes"" value=""' + p.Size + '"" />' + p.Size + '</td>';
            v");
                WriteLiteral(@"ar Color = '<td><input hidden name=""Colors"" value=""' + p.Color + '"" />' + p.Color + '</td>';
            var Qty = '<td> <input hidden name=""Qtys"" type=""text"" value=""' + p.Qty + '""/>' + p.Qty + '</td>';
            var PurchasePrice = '<td> <input hidden name=""Prices"" type=""text"" value=""' + p.PurchasePrice + '""/>' + p.PurchasePrice + '</td>';
            var TotalAmount = '<td>' + (p.Qty * p.PurchasePrice) + '</td>';
            var action = '<td><button type=""button"" class=""btn btn-xs btn-danger delete_Product""><span><i class=""mdi mdi-delete""></i></span></button></td>';


            var tr = '<tr id=""'+ sl +'"">' + sl + Image + Code + Description + Model + Size + Color + Qty + PurchasePrice + TotalAmount + action  + '</tr>'

            $('#productlist').append(tr);
            calculatePurchageProduct();
            ClearField()


        }


        //Autocomplete Section
        $.ui.autocomplete.prototype._renderMenu = function (ul, items) {
            var self = this;
            //");
                WriteLiteral(@"table definitions

            ul.append(""<div class='divAutocomplete' style='height:200px; overflow-y:scroll; z-index:10000'><table class='prodcutAutocomplete table table-border'><thead class='bg-secondary text-white'><tr> <th>Sl</th> <th>Code</th> <th>Description</th> <th>Category</th> <th>Model</th> <th>Size</th> <th>Color</th> </tr></thead><tbody></tbody></table></div>"");
            $.each(items, function (index, item) {
                self._renderItemData(ul, ul.find(""table tbody""), item);
            });
        };
        $.ui.autocomplete.prototype._renderItemData = function (ul, table, item) {
            return this._renderItem(table, item).data(""ui-autocomplete-item"", item);
        };
        $.ui.autocomplete.prototype._renderItem = function (table, item) {

            //var items = JSON.stringify(item)
            return $(""<tr class='ui-menu-item' role='presentation'></tr>"")
                .attr(""data-val"", item.id) //this line for passing item to focus object and select objec");
                WriteLiteral(@"t
                //.data(""item.autocomplete"", item)
                //item.length == isNaN ? 1 : (item.length + 1)
                //<tr> <th>Sl</th> <th>Code</th> <th>Description</th> <th>Category</th> <th>Model</th> <th>Size</th> <th>Color</th> </tr >
                .append(""<td>"" + ($("".prodcutAutocomplete tbody tr"").length+1) + ""</td> <td>"" + item.code + ""</td> <td>"" + item.description + ""</td> <td>"" + item.category + ""</td> <td>"" + item.model + ""</td> <td>"" + item.size + ""</td> <td>"" + item.color + ""</td>"")
                .appendTo(table);
        };

        //radion Button Code Description Model Change event

        var searchfield=""model"" // this parameter is used for search code description model autocomplete globally
        $("".searchField"").change(function () {
            searchfield = $(this).val();
            $(""#txtsearchfield"").focus();


        })

        $(""#txtsearchfield"").autocomplete({
            minLength: 1,
            focus: function (event, ui) {
      ");
                WriteLiteral(@"          if (ui.item != undefined) {
                   var photopath = ""/Projects/Images/Product/"";
                    photopath = ui.item.photopath == null ? ""/Projects/Images/DefaultImage/No_Image_Available.jpg"" : photopath + ui.item.photopath

                   // $(""#txtImage"").val(ui.item.photopath),
                        $(""#txtProductId"").val(ui.item.value)

                        $(""#txtProductCode"").val(ui.item.code)
                        $(""#txtProductDescription"").val(ui.item.description)

                        $(""#txtProductModel"").val(ui.item.model)
                        $(""#txtProductSize"").val(ui.item.size)
                        $(""#txtProductColor"").val(ui.item.color)
                        $("".pimage"").attr(""src"", photopath)
                    $(""#txtImage"").val(ui.item.photopath)

                }
                return false;
            }, // end of focuas
            //you can write for select too
            select: function (event, ui) {
          ");
                WriteLiteral(@"      var photopath = ""/Projects/Images/Product/"";
                photopath = ui.item.photopath == null ? ""/Projects/Images/DefaultImage/No_Image_Available.jpg"" : photopath + ui.item.photopath
                $(""#txtProductCode"").val(ui.item.code),
                    $(""#txtProductId"").val(ui.item.value),
                    $(""#txtProductDescription"").val(ui.item.description),
                    $(""#txtProductModel"").val(ui.item.model),
                    $(""#txtProductSize"").val(ui.item.size),
                    $(""#txtProductColor"").val(ui.item.color),
                    $("".pimage"").attr(""src"", photopath)
                $(""#txtImage"").val(ui.item.photopath)
                //searchfield = """";
                return false
            },
            //source: projects,
             source: function (request, response) {
                $.ajax({
                    url: '");
#nullable restore
#line 422 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\Edit.cshtml"
                     Write(Url.Action("FindProduct","Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    method: ""Get"",
                    data: { term: request.term, searchField: searchfield},
                    dataType: ""JSON"",
                    success: function (data) {
                        var starttable = '<table>'
                        var endtable = '</table>'
                        var td = '<td> Rana </td>';
                        var tr = '<tr>' + td + '</tr>'
                        var table = starttable + tr + endtable
                        response(data.output)
                    },
                    error: function (err) {

                    }
                }) //end of ajax

            } // end of source bracket


        })
    });

        //random json values
        //var projects = [
        //    { id: 1, value: ""Thomas"", model: 134, description: ""Teacher"" },
        //    { id: 65, value: ""Richard"", model: 1743, description: ""Waiter"" },
        //    { id: 235, value: ""Harold"", model: 7342, description: ""Cleaner"" },
 ");
                WriteLiteral(@"       //    { id: 78, value: ""Santa Maria"", model: 787, description: ""Manager"" },
        //    { id: 75, value: ""Gunner"", model: 788, description: ""Director"" },
        //    { id: 124, value: ""Shad"", model: 124, description: ""Chairman"" },
        //    { id: 1233, value: ""Aziz"", model: 3544, description: ""Bangladeshi"" },
        //    { id: 244, value: ""Buet"", model: 7847, description: ""Student"" }
        //];
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PurchaseEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591