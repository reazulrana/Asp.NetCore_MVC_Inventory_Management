#pragma checksum "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1693af1194f751898213a8d8193565f2a1fbc915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Model_Create), @"mvc.1.0.view", @"/Views/Model/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1693af1194f751898213a8d8193565f2a1fbc915", @"/Views/Model/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"148930584db6c15a45ac36ad79fc8224fc9dfe08", @"/_ViewImports.cshtml")]
    public class Views_Model_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control find_category"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control find_brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Model", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
  
    ViewBag.Title = "Create Model";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc9159811", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12 m-auto"">

            <div class=""card"">
                <div class=""card-header bg-primary"">
                    <h4 class=""card-title text-white"">Create Model</h4>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc91510489", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 18 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n\r\n                        <div class=\"col-md-6 border-right\">\r\n\r\n");
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-2\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc91512539", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 29 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Categories);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-10\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc91514281", async() => {
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc91514590", async() => {
                        WriteLiteral("Select Category");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 32 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Categories;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n");
                WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-md-2\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc91517718", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 41 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.brandId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-10\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc91519457", async() => {
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc91519766", async() => {
                        WriteLiteral("Select Brand");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 44 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.brandId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc91522512", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 47 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.brandId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n\r\n");
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-2\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1693af1194f751898213a8d8193565f2a1fbc91524373", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 57 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Models);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                                <div class=""col-md-10"">
                                    <input class=""form-control newModel"" name=""newModel"" id=""newModel"" />
                                    <button type=""button"" class=""btn btn-outline-primary btn-sm addNewModel""><span class=""text-lg-left"">Add Model <i class=""fa fa-plus""></i></span> </button>
                                </div>
                            </div>



");
                WriteLiteral(@"
                            <div class=""row mt-3"">
                                <div class=""col-md-12 brandHeader"">

                                </div>

                            </div>
                            <div class=""row newmodelList"">
                            </div>

                        </div>");
                WriteLiteral("\r\n\r\n\r\n                            <div class=\"col-md-6 border-left\"> ");
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-12 modelNotFoundMessage"">

                                    </div>

                                </div>
                                <div class=""row modelList"">
                                </div>

                            </div>


                        </div>

                </div>
                <div class=""card-footer"">
                    <div class=""col-md-12"">

                        <button type=""submit"" class=""btn btn-outline-success btn-sm""> <span class=""text-lg-left"">Create <i class=""fa fa-plus""></i></span> </button>
                        <button class=""btn btn-outline-info btn-sm""><span class=""text-lg-left"">Goto List <i class=""fa fa-list""></i> </span> </button>

                    </div>
                </div>
            </div>
        </div>
    </div>


");
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
//const { ajax } = require(""jquery"");

        $(document).ready(function () {


            //sweetaler
            
            function sweetalert(message)
            {
                sweetAlert(""Oops..."", ""You Enter ( "" + message.toUpperCase() + "" ) Model Is Dulicate"", ""error"")
            }


            //toastr

            function toastrdanger(message) {
                toastr.error(message, ""Top Right"", {
                    positionClass: ""toast-top-right"",
                    timeOut: 5e3,
                    closeButton: !0,
                    debug: !1,
                    newestOnTop: !0,
                    progressBar: !0,
                    preventDuplicates: !0,
                    onclick: null,
                    showDuration: ""300"",
                    hideDuration: ""1000"",
                    extendedTimeOut: ""1000"",
                    showEasing: ""swing"",
                    hideEasing: ""linear"",
                    showMethod: ""fadeI");
                WriteLiteral(@"n"",
                    hideMethod: ""fadeOut"",
                    tapToDismiss: !1
                })
            }



            //Find Model from database By Brand

            $("".find_category"").change(function () {
                var cateId = $(this).find("":selected"").val();
                $.ajax({
                    url: '");
#nullable restore
#line 167 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
                     Write(Url.Action("LoadBrandByCategoryid","Model"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    method: 'GET',
                    data: { id: cateId},
                    dataType: 'JSON',
                    success: function (data)
                    {
                        $("".find_brand"").empty();
                        $("".find_brand"").append(""<option>Select Brand</option>"")
                        if (data.message == true)
                        {
                            $.each(data.output, function (i,v) {
                                //alert(v.brandName);
                                var option = '<option value=""' + v.id + '"">' + v.brandName + '</option>'
                                $("".find_brand"").append(option);
                            })
                        }
                    }
                })
            })

            //Add New Model
            $("".addNewModel"").click(function ()
            {
                var content = $("".newModel"").val();
                var modellistappend = $("".newmodelList"");
     ");
                WriteLiteral(@"           var brandid = $("".find_brand"").find("":selected"").val();
                var brandname = $("".find_brand"").find("":selected"").text();

                if (brandid == null || brandid == -1) {
                    sweetalert(""No Brand Selected Selected"")
                    return;
                }

                if (content == null || content.length == 0)
                {
                    sweetalert(""No Model Selected"")
                    $("".newModel"").focus();
                    return;
                }



                var findForDupliocateModel = findDuplicate(searchIntoElement = "".findForDupliocateModel"", findElement = ""input"", searchText=content)
                if (findForDupliocateModel == true)
                {
                    getMessege(message = ""The Model You Entered Is Found In The List"");
                    return

                }
                //show brandName into messagebox
                getMessege(message = brandname);
                v");
                WriteLiteral(@"ar newdiv  = appendModelToDiv(content = content, isbuttonshow = true, isbagesshow = true)
                $(modellistappend).append(newdiv);

                $("".newModel"").val('');

            })



            //for Bind click event with button in model
            $("".newmodelList"").on(""click"", ""button"", function ()
            {

                var msg = $(this).parent().parent().find(""input"").val();
                if (confirm(""Do You Want To Delete Model ('"" + msg +""')"")) {
                    $(this).parent().parent().remove();
                }
            })


            //for showing h4 messege
            function getMessege(message)
            {
                $("".modelNotFoundMessage"").empty();
                $("".modelNotFoundMessage"").append('<h4>' + message + '</h4>')
            }

            //search model into model list for duplicate

            function findDuplicate(searchIntoElement,findElement,searchText)
            {
                var element =");
                WriteLiteral(@" $(searchIntoElement).find(findElement)
                var blnflag = false


                $.each(element, function () {

                    var currewntElement = $(this)
                    if ($(currewntElement).val().toUpperCase() == searchText.toUpperCase()) {

                        $(currewntElement).parent().parent().addClass(""bg-danger text-white border border-danger"")

                        sweetalert(searchText) //notify with message if duplicate model found
            
//                        NotifyDuplicateMessage() //notify with message if duplicate model found

                        blnflag = true
                    }
                    else {
                        $(currewntElement).parent().parent().removeClass(""bg-danger text-white border border-danger"")
                    }

                })

                return blnflag
            }

            //notify with message if duplicate model found
            function NotifyDuplicateMessage() {
  ");
                WriteLiteral(@"              $(""#duplicate_message_show"").modal(""show"");
                $("".duplicate_message"").html(""You Enter ( "" + searchText.toUpperCase() + "" ) Model Is Dulicate"");
                setTimeout(function () {
                    $(""#duplicate_message_show"").modal('hide');
                }, 3000)
            }


            //create separate div for per model 
            function appendModelToDiv(content, isbuttonshow = false, isbagesshow = false,badgemsg="""")
            {
                //var brandid = $("".find_brand"").find("":selected"").val();
                var button = """";

                var bages = """";
                var badgemessage = badgemsg == """" ? ""New Model"" : badgemsg;
                
                

                var input = '<input hidden  value=""' + content +'"" name=""Models""/>'
                if (isbuttonshow == true)
                {
                    button = '<civ class=""form-group""> <button type=""button"" class=""col-md-5 pull-right btn btn-danger light");
                WriteLiteral(@" btn-sm btnRemoveModelFromList"">Remove</button> </div>'

                }

                if (isbagesshow == true)
                {
                    bages = '<span class=""badge badge-pill bg-blue text-white text-lg-left pull-right"">' + badgemessage + '</span>'
                }

                var divcol = '<div class=""form-group"">' + content + input + bages + '</div>'
//                var formgroup = '<div class=""form-group"">' + divcol + button + '</div>'
                var maindiv = '<div class=""col-md-12 border py-3 findForDupliocateModel"">' + divcol + button + '</div> '

                return maindiv;
            }





            //GetModelList and Load into ModelDropdown list by brand
            $("".find_brand"").change(function () {


                var brandid = $(this).find("":selected"").val();




                $.ajax({
                    url: '");
#nullable restore
#line 329 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Model\Create.cshtml"
                     Write(Url.Action("LoadModelByBrandid", "Model"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    method: 'GET',
                    data: { id: brandid},
                    dataType: 'Json',
                    success: function (data)
                    {

                        $("".modelList"").empty();

                        console.log(data.output);
                        if (data.message == true)
                        {
                            $.each(data.output, function (index, item) {

                                var modeldiv = appendModelToDiv(content = item.modelName, false, true, badgemsg=""Load From Database"")
                                $("".modelList"").append(modeldiv);
                            })
                                
                        }
                        else
                        {
                            toastrdanger(""Model Not Found For This Brand"")
                            //getMessege(message=""Model Not Found For This Brand"")

                        }

                    },
       ");
                WriteLiteral("             error: function (err)\r\n                    {\r\n                        alert(err.message);\r\n                    }\r\n\r\n                })\r\n\r\n            })\r\n\r\n\r\n\r\n\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
