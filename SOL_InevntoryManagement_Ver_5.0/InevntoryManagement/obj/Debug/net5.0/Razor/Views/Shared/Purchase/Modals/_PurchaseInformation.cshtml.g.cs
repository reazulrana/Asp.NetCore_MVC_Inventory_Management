#pragma checksum "E:\Asp.Net Core Project\SOL_InevntoryManagement_Ver_5.0\InevntoryManagement\Views\Shared\Purchase\Modals\_PurchaseInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91b79ba128671ded7d81e48127db954a74fa035a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Purchase_Modals__PurchaseInformation), @"mvc.1.0.view", @"/Views/Shared/Purchase/Modals/_PurchaseInformation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b79ba128671ded7d81e48127db954a74fa035a", @"/Views/Shared/Purchase/Modals/_PurchaseInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38317fe4f735627c15271726327f1d5a2ee9cabd", @"/_ViewImports.cshtml")]
    public class Views_Shared_Purchase_Modals__PurchaseInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
/*.modalTable{
    max-width:992px;
    overflow-x:scroll
}*/
</style>
<div class=""modal fade bd-example-modal-lg"" id=""Modal_Purchase_Details"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header bg-dark"">
                <h4 class=""modal-title text-white"">Purchase Invoice Details</h4>
                <button type=""button"" class=""close text-white"" data-dismiss=""modal"">
                    <span>&times;</span>
                </button>
            </div>
            <div class=""modal-body lefttext"">
                <div class=""row"">
                    <div class=""col-md-6 text-white p-2 border"">
                        <h4 class=""text-white bg-blue-dark px-3 py-2"">Vendor/Seller Information</h4>

");
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-6"">
                                <p class=""text-blue"">Purchase No</p>
                            </div>
                            <div class=""col-md-6"">
                                <h6 class=""text-blue"" id=""modalpurchaseno""><b>001</b></h6>
                            </div>
                        </div>

");
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-6"">
                                <p class=""text-blue"">Purchase Date</p>
                            </div>
                            <div class=""col-md-6"">
                                <h6 class=""text-blue"" id=""modalpurchasedate""><b></b></h6>
                            </div>
                        </div>

");
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-6"">
                                <p class=""text-blue"">Received Date</p>
                            </div>
                            <div class=""col-md-6"">
                                <h6 class=""text-blue"" id=""modalReceiveddate""><b></b></h6>
                            </div>
                        </div>


");
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-6"">
                                <p class=""text-blue"">Branch</p>
                            </div>
                            <div class=""col-md-6"">
                                <h6 class=""text-blue"" id=""modalbranch""><b></b></h6>
                            </div>
                        </div>


");
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-6"">
                                <p class=""text-blue"">Vendor</p>
                            </div>
                            <div class=""col-md-6"">
                                <h6  class=""text-blue"" id=""modalvendor""><b><a  class=""text-blue"" href=""#""></a></b></h6>
                            </div>
                        </div>


");
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-6"">
                                <p class=""text-blue"">Source</p>
                            </div>
                            <div class=""col-md-6"">
                                <h6 class=""text-blue"" id=""modalsource""><b></b></h6>
                            </div>
                        </div>


                    </div>




");
            WriteLiteral("\r\n                <div class=\"col-md-6 p-2 border\">\r\n                    <h4 class=\"text-white bg-success px-3 py-2\">Purchase Bill Information</h4>\r\n                    \r\n\r\n");
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <p class=""text-green"">Product Cost</p>
                        </div>
                        <div class=""col-md-6"">
                            <h6 class=""text-green"" id=""modalproductcost""><b></b></h6>
                        </div>
                    </div>

");
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <p class=""text-green"">Dues</p>
                        </div>
                        <div class=""col-md-6"">
                            <h6 class=""text-green"" id=""modaldues""><b></b></h6>
                        </div>
                    </div>


");
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <p class=""text-green"">Transport Cost</p>
                        </div>
                        <div class=""col-md-6"">
                            <h6 class=""text-green"" id=""modaltransportcost""><b></b></h6>
                        </div>
                    </div>




");
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <p class=""text-green"">Other Charges</p>
                        </div>
                        <div class=""col-md-6"">
                            <h6 class=""text-green"" id=""modalothercharges""><b></b></h6>
                        </div>
                    </div>




");
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <p class=""text-green"">Gross Bill Amount</p>
                        </div>
                        <div class=""col-md-6"">
                            <h6 class=""text-green"" id=""modalgrossbillamount""><b></b></h6>
                        </div>
                    </div>


");
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <p class=""text-green"">Discount</p>
                        </div>
                        <div class=""col-md-6"">
                            <h6 class=""text-green"" id=""modaldiscount""><b></b></h6>
                        </div>
                    </div>


");
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <p class=""text-danger"">Net Bill Amount</p>
                        </div>
                        <div class=""col-md-6"">
                            <h6 class=""text-danger"" id=""modalnetbillamount""><b></b></h6>
                        </div>
                    </div>


                </div>
                    <div class=""col-md-12"">
                        <h6 class=""text-blue"" id=""modalremarks""><small><b></b></small></h6>

                    </div>

      

                </div>


");
            WriteLiteral(@"
                        <div class=""row mt-2"">
                            <div class=""table-responsive mt-3"">
                                <table class=""table table-bordered text-center"">
                                    <thead class=""bg-blue"">
                                        <tr class=""text-white"">
                                            <th><small>SL</small></th>
                                            <th><small>Image</small></th>
                                            <th><small>Code</small></th>
                                            <th><small>Description</small></th>
                                            <th><small>Model</small></th>
                                            <th><small>Size</small></th>
                                            <th><small>Color</small></th>
                                            <th><small>Qty</small></th>
                                            <th><small>Price</small></th>
                           ");
            WriteLiteral("                 <th><small>Total Amount</small></th>\r\n");
            WriteLiteral(@"
                                        </tr>
                                    </thead>
                                    <tbody class=""table-danger light"" id=""modalproductlist"">
                                    </tbody>

                                </table>
                            </div>

                        </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-youtube btn-xs"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>





");
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
