#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb157dd060903f53c2e14d5f0f422a9ffcd5e47d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HO_FundRechargeRequestReport), @"mvc.1.0.view", @"/Views/HO/FundRechargeRequestReport.cshtml")]
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
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb157dd060903f53c2e14d5f0f422a9ffcd5e47d", @"/Views/HO/FundRechargeRequestReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HO_FundRechargeRequestReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
  
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
        <li><a href=""#0"">Fund Recharge Request Report</a></li>
      </ol>
    </div>
    <div class=""dashboard-center-itm"">
      <div class=""cm-table-data"">
        <div class=""cm-table-data-in"">
");
            WriteLiteral(@"          <table id=""cmDataTable"" class=""display table"" cellspacing=""0"" width=""100%"">
            <thead>
              <tr>
                <th>#</th>
                <th>Investor Id</th>
                <th>Request Date</th>
                <th>Reference no.</th>
                <th>Dhanu amt.</th>
                <th>USDT amt.</th>
                <th>TP USDT amt.</th>
                <th>Receipt</th>
                <th>Status</th>
                <th></th>
              </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 45 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                
                var i = 0;
                foreach (DataRow dr in (ViewData["_report"] as DataTable).Rows)
                {
                  i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\r\n                    <td>");
#nullable restore
#line 51 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><span>");
#nullable restore
#line 52 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                         Write(dr["LoginId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 52 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                                                               Write(dr["Fullname"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    <td><p>");
#nullable restore
#line 53 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                      Write(dr["Requestdate"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td><p>");
#nullable restore
#line 54 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                      Write(dr["TrReferenceno"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td><p>$ ");
#nullable restore
#line 55 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                        Write(dr["DhanuAmount"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td><p>$ ");
#nullable restore
#line 56 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                        Write(dr["UsdtAmount"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td><p>$ ");
#nullable restore
#line 57 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                        Write(dr["TpUsdtAmount"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td><p>");
#nullable restore
#line 58 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                      Write(dr["ReceiptUrl"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td><p>");
#nullable restore
#line 59 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                      Write(dr["Status"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td>\r\n                      <p>\r\n");
#nullable restore
#line 62 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                         if (@dr["StatusId"].ToString() == "0")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb157dd060903f53c2e14d5f0f422a9ffcd5e47d8886", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2528, "~/Ho/WalletRecharge/", 2528, 20, true);
#nullable restore
#line 64 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
AddHtmlAttributeValue("", 2548, dr["RequestId"].ToString(), 2548, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 65 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      </p>\r\n                    </td>\r\n                  </tr>\r\n");
#nullable restore
#line 70 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\FundRechargeRequestReport.cshtml"
                }
              

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n          </table>\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n  </div>\r\n\r\n</div>\r\n\r\n");
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