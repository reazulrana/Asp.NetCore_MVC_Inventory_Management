#pragma checksum "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Jquery_Glabal_Partial\_VendorCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba4779ae763f79b0b2975ee88c6f7e8cdb5a3bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Jquery_Glabal_Partial__VendorCreate), @"mvc.1.0.view", @"/Views/Shared/Jquery_Glabal_Partial/_VendorCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba4779ae763f79b0b2975ee88c6f7e8cdb5a3bd3", @"/Views/Shared/Jquery_Glabal_Partial/_VendorCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cad59e37cf3cc5e4fb7330fd2bf4e1e8c02e6ea", @"/_ViewImports.cshtml")]
    public class Views_Shared_Jquery_Glabal_Partial__VendorCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Jquery_Glabal_Partial\_VendorCreate.cshtml"
   
    string tabcollabel = "col-md-3";
    string tabcolinput = "col-md-9";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row bg-danger-light py-2\" id=\"divVendor\" style=\"display:none\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 197, "\"", 217, 1);
#nullable restore
#line 8 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Jquery_Glabal_Partial\_VendorCreate.cshtml"
WriteAttributeValue("", 205, tabcollabel, 205, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <label for=\"txtSaveVendor\">Name</label>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 290, "\"", 310, 1);
#nullable restore
#line 11 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Jquery_Glabal_Partial\_VendorCreate.cshtml"
WriteAttributeValue("", 298, tabcolinput, 298, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input class=\"form-control\" id=\"txtSaveVendor\" placeholder=\"Enter Vendor Name\" />\r\n    </div>\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 427, "\"", 447, 1);
#nullable restore
#line 15 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Jquery_Glabal_Partial\_VendorCreate.cshtml"
WriteAttributeValue("", 435, tabcollabel, 435, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <label for=\"txtSaveVendor\">Address</label>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 523, "\"", 543, 1);
#nullable restore
#line 18 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Jquery_Glabal_Partial\_VendorCreate.cshtml"
WriteAttributeValue("", 531, tabcolinput, 531, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input class=\"form-control\" id=\"txtSaveVendorAddress\" placeholder=\"Enter Vendor Address\" />\r\n    </div>\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 670, "\"", 690, 1);
#nullable restore
#line 22 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Jquery_Glabal_Partial\_VendorCreate.cshtml"
WriteAttributeValue("", 678, tabcollabel, 678, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <label for=\"txtSaveVendor\">Context</label>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 766, "\"", 786, 1);
#nullable restore
#line 25 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Jquery_Glabal_Partial\_VendorCreate.cshtml"
WriteAttributeValue("", 774, tabcolinput, 774, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        <label class=""mt-1"">
            <input class=""form-check-inline"" type=""checkbox"" id=""IsSelectedVendor"" />Default
        </label>
        <input class=""form-control"" id=""txtSaveVendorContact"" placeholder=""Enter Vendor Contact"" />
        <button type=""button"" data-request-url='");
#nullable restore
#line 30 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Jquery_Glabal_Partial\_VendorCreate.cshtml"
                                           Write(Url.Action("Create_Vendor_With_Ajax", "Vendor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' class=\"btn btn-whatsapp btn-xs pull-right\" id=\"btnSaveVendor\">Add <span><i class=\"mdi mdi-plus\"></i></span></button>\r\n    </div>\r\n</div>");
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
