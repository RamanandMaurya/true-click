#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffc2289dfdab08a355da00277f842f913f5bae9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_UsdtWalletReport), @"mvc.1.0.view", @"/Views/Member/UsdtWalletReport.cshtml")]
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
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\_ViewImports.cshtml"
using webcode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\_ViewImports.cshtml"
using webcode.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffc2289dfdab08a355da00277f842f913f5bae9b", @"/Views/Member/UsdtWalletReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Member_UsdtWalletReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
  
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
                <li><a href=""#0"">USDT Wallet Report</a></li>
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
                                <th>Tr. Date</th>
                                <th>Tr. Type</th>
                                <th>Coin Rate ($)</th>
                                <th>Coin</th>
                                <th>Amount ($)</th>
                                <th>Reference no.</th>
                                <th>Tr. Name</th>
                                <th>Remark</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 44 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                              
                                var i = 0;
                                foreach (DataRow dr in (ViewData["_report"] as DataTable).Rows)
                                {
                                    i++;
                                    string color = "";
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                     if (@dr["Transactiontype"].ToString().ToUpper() == "CR.")
                                    {
                                        color = "crColor";
                                    }
                                    else if (@dr["Transactiontype"].ToString().ToUpper() == "DB.")
                                    {
                                        color = "dbColor";
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr");
            BeginWriteAttribute("class", " class=\"", 2712, "\"", 2726, 1);
#nullable restore
#line 59 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
WriteAttributeValue("", 2720, color, 2720, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <td>");
#nullable restore
#line 60 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><p>");
#nullable restore
#line 61 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                          Write(dr["Transactiondate"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 62 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                          Write(dr["Transactiontype"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 63 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                          Write(dr["CoinRate"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 64 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                          Write(dr["Coin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 65 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                          Write(dr["Amount"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 66 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                          Write(dr["TransactionReferenceno"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 67 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                          Write(dr["TransactionName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><p>");
#nullable restore
#line 67 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                                                                  Write(dr["TransactionStatus"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 68 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                          Write(dr["Remark"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 70 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\Member\UsdtWalletReport.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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