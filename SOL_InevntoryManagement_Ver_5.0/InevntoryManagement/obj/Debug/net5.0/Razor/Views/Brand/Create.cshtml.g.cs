#pragma checksum "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Brand\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "545f5708a5edb70bdf7ef75ecd68db00d042c2fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brand_Create), @"mvc.1.0.view", @"/Views/Brand/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"545f5708a5edb70bdf7ef75ecd68db00d042c2fb", @"/Views/Brand/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6427877eb2fa568eb4ebf807c303ddef6b14e37", @"/_ViewImports.cshtml")]
    public class Views_Brand_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrandCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger text-xxl-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("js-example-theme-single categoryId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBrandList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-right btn btn-info btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Brand\Create.cshtml"
  
    ViewBag.Title = "Create Brand";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <style>\r\n        .card {\r\n            border: red 5px !important;\r\n        }\r\n    </style>\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "545f5708a5edb70bdf7ef75ecd68db00d042c2fb9621", async() => {
                WriteLiteral(@"
    <div class=""card  m-auto"" id=""brandList"">
        <div class=""card-header bg-secondary"">
            <h3 class=""card-title text-white"">Category Brand</h3>
        </div>
        <div class=""card-body"">
            <div class=""row"" id=""add_group_brand"">
                <div class=""col-md-12"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "545f5708a5edb70bdf7ef75ecd68db00d042c2fb10218", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Brand\Create.cshtml"
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
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>");
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "545f5708a5edb70bdf7ef75ecd68db00d042c2fb12084", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 30 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Brand\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.cateid);

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
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-10\">\r\n\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "545f5708a5edb70bdf7ef75ecd68db00d042c2fb13683", async() => {
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "545f5708a5edb70bdf7ef75ecd68db00d042c2fb13972", async() => {
                        WriteLiteral("Select Category");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 35 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Brand\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.cateid);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 35 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Brand\Create.cshtml"
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
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "545f5708a5edb70bdf7ef75ecd68db00d042c2fb17170", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 38 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Brand\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.cateid);

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
                WriteLiteral("\r\n\r\n");
                WriteLiteral("            </div>\r\n\r\n\r\n\r\n\r\n        </div>\r\n    \r\n        <div class=\"row mt-2\">\r\n\r\n\r\n            <div class=\"col-md-2\">\r\n                <label class=\"col-md-12\">Brand</label>\r\n            </div>\r\n");
                WriteLiteral(@"
        <div class=""col-md-10"">
            <input class=""form-control"" id=""Brand"" />
            <button type=""button"" class=""btn btn-facebook btn-xs"" id=""addBrand"">Add Brand<span class=""btn-icon-right""><i class=""mdi mdi-plus""></i></span></button>
            <span class=""text-danger my-1"" id=""validationMessage"" style=""display:none""></span>
");
                WriteLiteral("            <div class=\"row mt-4\">\r\n                <div class=\"col-md-12\" id=\"brandsection\">\r\n                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n");
                WriteLiteral("\r\n");
                WriteLiteral(@"






            </div> 



     

        </div>

        <div class=""card-footer"">
            <div class=""form-group"">
                <button class=""btn btn-success btn-xs"">Create <span class=""btn-icon-right""> <i class=""mdi mdi-plus""></i></span></button>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "545f5708a5edb70bdf7ef75ecd68db00d042c2fb20126", async() => {
                    WriteLiteral("Go To List <span class=\"btn-icon-right\"><i class=\"mdi mdi-view-list\"></i></span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"    <script>


    $(document).ready(function () {

        /*showDuplicateModal(""Test External Method"");*/



        //$('.js-example-theme-single').select2();


        //sweetaler

        function sweetalert(message) {
            
            sweetAlert(""Oops..."", ""'"" + message.toUpperCase() + ""'"", ""error"")
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
                showMethod: ""fadeIn"",
                hideMethod: ""fadeOut"",
      ");
                WriteLiteral(@"          tapToDismiss: !1
            })
        }




    $(""#addBrand"").click(function () {



        var txt = $(""#Brand"").val();


        var opt =
        {
            'text': $("".categoryId"").find("":selected"").text(),
            'value': $("".categoryId"").find("":selected"").val()
        }

        if (opt.value == -1) {
            sweetalert(""Select Category First"")
            return
        }


        var blnduplicateBrand = findDuplicate(searchIntoElement = ""#brandsection"", findElement = ""input"", searchText = txt);
        if (blnduplicateBrand == true)
        {
            return;
        }

        
       
        $(""#validationMessage"").hide();
        if (txt.length == 0)
        {
            //$(""#validationMessage"").html(""Brand Field Is Required"").show();
            sweetalert(""Brand Filed Is Blank"")
            $(""#Brand"").focus();

        return;
        }
        else
        {

        if (opt.value == null)
        {
        sweeta");
                WriteLiteral(@"lert(""Category Is Empty Or Not Selected"");
        return
        }


        //var card = dynamicCard(opt.text, txt.toUpperCase(), btnshow= true, bages= true)
            var card = appendBrandToDiv(content = txt.toUpperCase(), isbuttonshow = true, isbagesshow = true, ""Load From Database"");

        $(""#brandsection"").append(card);

    }

    })




        //search Brand into model list for duplicate

        function findDuplicate(searchIntoElement, findElement, searchText) {
            var element = $(searchIntoElement).find(findElement)
            var blnflag = false


            $.each(element, function () {

                var currewntElement = $(this)
                if ($(currewntElement).val().toUpperCase() == searchText.toUpperCase()) {

                    $(currewntElement).parent().parent().addClass(""bg-danger text-white border border-danger"")

                    sweetalert(""The Brand You Enterd '"" + searchText + ""' Is Duplicate"") //notify with message if dup");
                WriteLiteral(@"licate model found

                    //                        NotifyDuplicateMessage() //notify with message if duplicate model found

                    blnflag = true
                }
                else {
                    $(currewntElement).parent().parent().removeClass(""bg-danger text-white border border-danger"")
                }

            })

            return blnflag
        }


        //git Update


        //create separate div for per model 
        function appendBrandToDiv(content, isbuttonshow = false, isbagesshow = false, badgemsg = """") {
            //var brandid = $("".find_brand"").find("":selected"").val();
            var button = """";


          
       

            var bages = """";
            var badgemessage = badgemsg == """" ? ""New Model"" : badgemsg;



            var input = '<input hidden  value=""' + content + '"" name=""Brands""/>'
            if (isbuttonshow == true) {
                button = '<civ class=""col-md-12 mt-1""> <button type=""b");
                WriteLiteral(@"utton"" class=""pull-right btn btn-youtube btn-xs btnRemoveModelFromList"">Remove <span class=""btn-icon-right""><i class=""mdi mdi-delete""></i></span></button> </div>'

            }


            if (isbagesshow == true) {
                bages = '<span class=""badge badge-pill bg-blue text-white text-lg-left pull-right"">' + badgemessage + '</span>'
            }


            // Show Serial Nu for Brand
            
            var slno = $('.slBrandhtml');
            if (slno === undefined) {
                slno =  1
         


            }
            sl = ($(slno).length + 1)
        
            var sldiv = '<div class=""col-md-2 slBrandhtml"">'+sl+'</div>'

            var divcol = sldiv + '<div class=""col-md-10"">' + content + input + bages + '</div>'
            //                var formgroup = '<div class=""form-group"">' + divcol + button + '</div>'
            var maindiv = '<div class=""row border-bottom py-1 findForDupliocateModel"">' + divcol + button + '</div> '

           ");
                WriteLiteral(@" return maindiv;
        }





        ////function duplicate brand search
        //function findDuplicateBrand (text)
        //{
        //    var b = false;
        //    $("".searchBrand"").each(function () {

        //        var v = $(this).find(""input"").val();
        //        var addcolor = $(this).find(""input"").parent().parent().find("".card-header"")
        //        if (text.toUpperCase() == v.toUpperCase()) {
        //            $(addcolor).append('<div><h4 class=""text-white text_duplicate""> This is Duplcate Brand </h4></div>')
        //            $(addcolor).removeClass(""bg-danger-light"").addClass(""bg-danger"")

        //            sweetalert(""You Enter ( "" + searchText.toUpperCase() + "" ) Model Is Dulicate"")
        //            //NotifyDuplicateMessage() //notify with message if duplicate model found

        //        }
        //        else
        //        {
        //            $(addcolor).find("".text_duplicate"").remove();
        //            $(addcolor");
                WriteLiteral(@").removeClass(""bg-danger"")
        //            $(addcolor).addClass(""bg-danger-light"")
        //        }
        //    })

        //    return b
        //}


        //notify with message if duplicate model found
        //function NotifyDuplicateMessage() {
        //    $(""#duplicate_message_show"").modal(""show"");
        //    $("".duplicate_message"").html(""You Enter ( "" + searchText.toUpperCase() + "" ) Model Is Dulicate"");
        //    setTimeout(function () {
        //        $(""#duplicate_message_show"").modal('hide');
        //    }, 3000)
        //}

    // Load Dynamically html bootstrap Card

        function dynamicCard(valheader, valbody, btnshow = true, bagesshow = false)
        {
            var bages = """";
            if (bagesshow == true)
            {
                bages = '<span class=""badge bg-blue text-white font-weight-bold pull-right""> New Add </span>'
            }

            var cardFooter = """";
            var cardHeader = '<div style=""display");
                WriteLiteral(@":block"" class=""card-header bg-danger-light""><h4 class=""card-title"">' + valheader + '</h4></div>'
            var cardbody = '<div class=""card-body"">' + valbody + bages + '<input name=""Brands"" hidden value=""' + valbody.toUpperCase() + '""/></div>'
            if (btnshow == true) {
                cardFooter = '<div class=""card-footer""><button type=""button"" class=""btn btn-block btn-danger light btn-sm brandRemove"">Remove</button></div>'
            }
            else {
                cardFooter = '<div class=""card-footer bg-danger-light""></div>'
            }
            var card = '<div class=""col-md-3"">'
                + '<div class=""card searchBrand"">' +
                cardHeader +
                cardbody +
                cardFooter+
                 '</div>' +
                 '</div>'


            return card
        }




    /*else {*/
    //    //Check if Brand is Exist or Not
    //    let blnf = CheckDuplicate(txt);
    //    if (blnf)
    //    {
    //        $(""#va");
                WriteLiteral(@"lidationMessage"").html(""The Brand Is Exist In List"").show();
    //        return
    //    }


    //    var sl = $(""#brandList tr"").length
    //    var inputtext = '<input name=""Brands"" hidden value=""' + txt.toUpperCase() + '""/>'
    //    var tdsl = ""<td>"" + (sl + 1) + ""</td>""
    //    var tdBrand = ""<td>"" + txt.toUpperCase() + inputtext + ""</td>""
    //    var tdButton = ""<td><button type='button' class='btn btn-block btn-sm btn-danger light remove_brand_from_list'>Remove </button></td>""


    //    var tr = ""<tr>"" + tdsl + tdBrand  + tdButton + ""</tr>""

    //    $(""#brandList"").append(tr);

    //}









    // for remove brand from list
    $(""#brandsection"").on('click', 'button', function () {


        var msg = $(this).parent().parent().find(""input"").val();
        if (confirm(""Do You Want To Delete Model ('"" + msg + ""')"")) {
            $(this).parent().parent().remove();
        }

        //if (confirm(""Do You Want To Delete Brand""))

        //{
       ");
                WriteLiteral(@" //    $(this).parent().parent().parent().fadeOut();
        //}
    })


    //Check Duplication if Brand is Exist or Not
    function CheckDuplicate(value)
    {

        var val = value.toLowerCase()
    var blnflag = false;

    $(""#brandList tr"").each(function (i) {
    $(this).find('input').each(function () {

    if (val == $(this).val().toLocaleLowerCase())
    {
    blnflag = true;
    return
    }

    })
    })
    return blnflag;
    }


    $("".categoryId"").change(function () {

        var brandid = returnDropdownSelectedValue(this).dropdown_value

        //Clean The List of brands before load Brand into list
        $(""#brandsection"").empty()
        //if Select Category is select
        if (brandid == -1)
        {

            return;
        }

    $.ajax({
    url: '");
#nullable restore
#line 454 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Brand\Create.cshtml"
     Write(Url.Action("findBrand", "Brand"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
    method: ""POST"",
    data: { id: brandid },
    dataType: ""JSON"",
    success: function (data)
    {
        //var d = JSON.parse(data);
        var category = $(""#cateid"").find("":selected"").text();
        if (data.output != null && data.output.length != 0) {

            $.each(data.output, function (i,item) {

                // var card = dynamicCard(category, item.brandName, btnshow = false, bagesshow=false)
                var card = appendBrandToDiv(content = item.brandName, isbuttonshow = false, isbagesshow = true, ""Load From Database"");
                
                $(""#brandsection"").append(card);
            })
            return
        }
        else
        {

        }

        $.each(data.output, function (x, item) {

            alert(item.brandName)

        })



    }
    }) //end of ajax call
    })

    function returnDropdownSelectedValue(data)
    {
    var tdata =
    {

        'dropdown_value': $(data).find("":selected"").val(),
     ");
                WriteLiteral("   \'dropdown_text\': $(data).find(\":selected\").text,\r\n    }\r\n\r\n    return tdata;\r\n    }\r\n\r\n\r\n    })\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrandCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
