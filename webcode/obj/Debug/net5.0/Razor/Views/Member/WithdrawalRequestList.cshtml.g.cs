#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e40da7f66c2da9e7a6ad4b9d9c66d1bab471d0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_WithdrawalRequestList), @"mvc.1.0.view", @"/Views/Member/WithdrawalRequestList.cshtml")]
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
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\_ViewImports.cshtml"
using webcode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\_ViewImports.cshtml"
using webcode.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e40da7f66c2da9e7a6ad4b9d9c66d1bab471d0d", @"/Views/Member/WithdrawalRequestList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Member_WithdrawalRequestList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
  
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dss-right-section noside-right-full"">
    <div class=""dashboard-center"">
        <div class=""custom-breadcrumb"">
            <ol class=""cd-breadcrumb"">
                <li><a href=""#"">Dashboard</a></li>
                <li><a href=""#0"">Withdrawal Request Report</a></li>
            </ol>
        </div>
        <div class=""dashboard-center-itm"">
            <div class=""cm-table-data"">
                <div class=""cm-table-data-in"">
");
            WriteLiteral(@"                    <table id=""cmDataTable"" class=""display table"" cellspacing=""0"" width=""100%"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Req. Date</th>
                                <th>Request Coin</th>
                                <th>Platform Fees</th>
                                <th>Transfer Coin</th>
                                <th>Wallet Type</th>
                                <th>Deposit Address</th>
                                <th>Status</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 43 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                              
                                var i = 0;
                                foreach (DataRow dr in (ViewData["_report"] as DataTable).Rows)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th>");
#nullable restore
#line 49 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td><p>");
#nullable restore
#line 50 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                                      Write(dr["EntryDate"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                    <td><p>");
#nullable restore
#line 51 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                                      Write(dr["RequestCoin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                    <td><p>");
#nullable restore
#line 52 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                                      Write(dr["PlatformFees"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                    <td><p>");
#nullable restore
#line 53 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                                      Write(dr["TransferCoin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                    <td><p>");
#nullable restore
#line 54 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                                      Write(dr["Wallet"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                    <td><p>");
#nullable restore
#line 55 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                                      Write(dr["Address"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                    <td><p>");
#nullable restore
#line 56 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                                      Write(dr["Status"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                </tr>\r\n");
#nullable restore
#line 58 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalRequestList.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
