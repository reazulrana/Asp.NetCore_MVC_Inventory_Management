#pragma checksum "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240b409f4a0ea5d275161c264b9cc032a7076ac8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_PurchaseList), @"mvc.1.0.view", @"/Views/Purchase/PurchaseList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240b409f4a0ea5d275161c264b9cc032a7076ac8", @"/Views/Purchase/PurchaseList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b9aba351aa2b9ae5f03984feb2138cf7d05494b", @"/_ViewImports.cshtml")]
    public class Views_Purchase_PurchaseList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PurchaseListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-md-right btn btn-facebook btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPurchaseList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 float-md-right btn btn-facebook btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
  
    ViewBag.Title = "Purchase Invoice List";
    string tdwidth = "200px";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    th {
        white-space: nowrap;
    }
    td {
        white-space: nowrap;
    }
    </style>


<div class=""card"">
    <div class=""card-header"">
        <h4 class=""card-title text-white"">Purchase Invoice List</h4>
    </div>
    <div class=""card-body"">

        <div class=""row"">
            <div class=""col-md-12"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "240b409f4a0ea5d275161c264b9cc032a7076ac810156", async() => {
                WriteLiteral("Create<span><i class=\"ml-1 mdi mdi-plus\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral(@"            <div class=""row mt-2"">
                <div class=""col-md-12 mt-3"">
                    <table class=""table table-bordered  table-danger table-responsive text-center"">
                        <thead class=""bg-info"">
                            <tr class=""text-white"">
                                <th>SL</th>
                                <th title=""Purchase No""><small>#P. No</small></th>
                                <th title=""Purchase Date""><small>P. Date</small></th>
                                <th title=""Branch""><small>Branch</small></th>
                                <th title=""Vendor""><small>Vendor</small></th>
                                <th title=""Source""><small>Source</small></th>
                                <th title=""Product Cost""><small>Product Cost</small></th>
                                <th title=""Cash Payment""><small>Cash Payment</small></th>
                                <th title=""Dues""><small>Dues</small></th>
                             ");
            WriteLiteral(@"   <th title=""Transport""><small>Transport</small></th>
                                <th title=""Others""><small>Others</small></th>
                                <th title=""Gross Amount""><small>Gross Bill Amount</small></th>
                                <th title=""Discount""><small>Discount</small></th>
                                <th title=""Net Amount""><small>Net Bill Amount</small></th>

                            </tr>
                        </thead>
                        <tbody id=""productlist"">
");
#nullable restore
#line 55 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                             if (Model == null || Model.Count == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td colspan=\"15\">Purchase Invoice Not Avaulable</td>\r\n                                </tr>\r\n");
#nullable restore
#line 60 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                            }
                            else
                            {
                                int sl = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                 foreach (var m in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr data-id=\"");
#nullable restore
#line 66 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                            Write(m.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        <td>");
#nullable restore
#line 67 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(sl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><a href=\"#\" data-id=\"");
#nullable restore
#line 68 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                                            Write(m.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"showModalProductDetails\" data-toggle=\"modal\" data-target=\"#Modal_Purchase_Details\"><h6> ");
#nullable restore
#line 68 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                                                                                                                                               Write(m.PurchaseNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></a></td>\r\n                                        <td>");
#nullable restore
#line 69 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.TrDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 70 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.Branch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 71 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.Vendor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 72 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 73 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 74 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.PaymentOnCash);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 75 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.Dues);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 76 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.Transport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 77 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.Others);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 78 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.GrossAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 79 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 80 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                       Write(m.NetAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 82 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                    sl = sl + 1;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n\r\n                    </table>\r\n                </div>\r\n\r\n            </div>\r\n");
            WriteLiteral("    </div>\r\n    <div class=\"card-footer\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "240b409f4a0ea5d275161c264b9cc032a7076ac821023", async() => {
                WriteLiteral("Edit List<span class=\"btn-icon-right\"><i class=\"ml-1 mdi mdi-view-list\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 116 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
Write(Html.Partial("~/Views/Shared/Purchase/Modals/_PurchaseInformation.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 

    <script>
    $(document).ready(function ()
    {


        $(""#productlist tr"").dblclick(function () {

            let id = $(this).data(""id"");
            ajaxcall(id)
        })


        function ajaxcall(id)
        {


            $.ajax({
                url: '");
#nullable restore
#line 141 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                 Write(Url.Action("ShowPurchaseDetails","Purchase"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                method: ""POST"",
                data: { id: id },
                dataType: ""JSON"",
                success: function (data)
                {

                    if (data.output != null)
                    {
                        $(""#modalpurchaseno b"").text(data.output.purchaseno);
                        $(""#modalpurchasedate b"").text(data.output.trDate);
                        $(""#modalReceiveddate b"").text(data.output.trDate);
                        $(""#modalbranch b"").text(data.output.branch);
                        $(""#modalvendor b a"").text(data.output.vendor);
                        $(""#modalsource b"").text(data.output.source);
                        $(""#modalproductcost b"").text(data.output.totalAmount);
                        $(""#modaldues b"").text(data.output.dues);
                        $(""#modaltransportcost b"").text(data.output.transport);
                        $(""#modalothercharges b"").text(data.output.others);
                        $(""#mod");
                WriteLiteral(@"algrossbillamount b"").text(data.output.grossAmount);
                        $(""#modaldiscount b"").text(data.output.discount);
                        $(""#modalnetbillamount b"").text(data.output.netAmount);
                        $(""#modalremarks small b"").text(data.output.remarks);

                        $(""#modalvendor b a"").attr(""href"", '");
#nullable restore
#line 165 "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Purchase\PurchaseList.cshtml"
                                                       Write(Url.Action("VendorPanel","Vendor"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?vendor=' + data.output.vendor )
                    }
                    $(""#modalproductlist"").empty()
                    $.each(data.output.purchaseProductInfos, function (i, item) {

                        //console.log(item);
                        newRowAppend(item)

                    })
                    //console.log(data.output);

                    //console.log(data.output.purchaseProductInfos);

                }
            })//end of ajax call


            $(""#Modal_Purchase_Details"").modal('toggle')

        }
        $(""#showModalProductDetails"").click(function () {
            let id = $(this).data(""id"")
            //alert(id);
            ajaxcall(id)
        })




        function newRowAppend(data)
        {

            let tblbody = $(""#modalproductlist"")
            sl = $(""#modalproductlist tr"").length
            sl= (sl == null || sl == undefined || sl==0)? 1 : (sl+1)
            let imgpath = ""/Projects/Images/Product/"";
            //");
                WriteLiteral(@"var photopath = """";
            //photopath = ui.item.photopath == null ? "" : photopath + ui.item.photopath

            imgpath = (data.photopath == null || data.photopath == """") ? ""/Projects/Images/DefaultImage/No_Image_Available.jpg"" : imgpath + data.photopath

            let tdsl = '<td>' + sl + '</td>'
            let tdimage = '<td> <img height=72 width=72 src=""' + imgpath + '"" /></td>'
            let tdcode = '<td>' + data.code + '</td>'
            let tddescription = '<td>' + data.description + '</td>'
            let tdmodel = '<td>' + data.model + '</td>'
            let tdsize = '<td>' + data.size + '</td>'
            let tdcolor = '<td>' + data.color + '</td>'
            let tdqty = '<td>' + data.qty + '</td>'
            let tdprice = '<td>' + data.price + '</td>'
            let tdtotalamount = '<td>' + (data.qty * data.price) + '</td>'

            let tr = ""<tr>"" + tdsl + tdimage + tdcode + tddescription + tdmodel + tdsize + tdcolor + tdqty + tdprice + tdtotalamount + ""</t");
                WriteLiteral("r>\"\r\n            $(tblbody).append(tr);\r\n\r\n\r\n\r\n\r\n\r\n        }\r\n\r\n    })\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PurchaseListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
