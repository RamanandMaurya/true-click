#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ba34b79e5cb10afc61c7a2e265826faf4c70582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HO_RewardReport), @"mvc.1.0.view", @"/Views/HO/RewardReport.cshtml")]
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
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\_ViewImports.cshtml"
using webcode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\_ViewImports.cshtml"
using webcode.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ba34b79e5cb10afc61c7a2e265826faf4c70582", @"/Views/HO/RewardReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HO_RewardReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
  
    Layout = "~/Views/Shared/_HOLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dss-right-section noside-right-full"">
    <div class=""dashboard-center"">
        <div class=""custom-breadcrumb"">
            <ol class=""cd-breadcrumb"">
                <li><a href=""#"">Dashboard</a></li>
                <li><a href=""#0"">Reward report</a></li>
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
                                <th>Investor ID</th>

                                <th>Mobile</th>
                                <th>Email</th>
                                <th>Designation</th>
                                <th>Gift</th>
                                <th>AcheiveDate</th>

");
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n\r\n                        <tbody>\r\n");
#nullable restore
#line 52 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                              
                                var i = 0;
                                foreach (DataRow dr in (ViewData["_report"] as DataTable).Rows)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 58 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><span>");
#nullable restore
#line 59 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                                             Write(dr["LoginId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span>");
#nullable restore
#line 59 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                                                                                    Write(dr["Name"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n\r\n\r\n                                        <td><p>");
#nullable restore
#line 62 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                                          Write(dr["Mobile"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 63 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                                          Write(dr["Email"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>$ ");
#nullable restore
#line 64 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                                            Write(dr["Designation"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>$ ");
#nullable restore
#line 65 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                                            Write(dr["Gift"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 66 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                                          Write(dr["Acheivedate"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 78 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\RewardReport.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
