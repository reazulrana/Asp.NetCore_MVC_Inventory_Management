#pragma checksum "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06235d278041c19ca5c383287c4d346af40d0a05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06235d278041c19ca5c383287c4d346af40d0a05", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"690000e0c2bf0b582bb5a7a8ef47e4fbeb661085", @"/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Admin_Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Admin Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "06235d278041c19ca5c383287c4d346af40d0a057617", async() => {
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
