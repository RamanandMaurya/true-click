#pragma checksum "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "549d58529249f57d9d8ce8bdca086cfd1c699588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HO_BaapNetworkDhanuReport), @"mvc.1.0.view", @"/Views/HO/BaapNetworkDhanuReport.cshtml")]
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
#line 1 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\_ViewImports.cshtml"
using webcode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\_ViewImports.cshtml"
using webcode.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"549d58529249f57d9d8ce8bdca086cfd1c699588", @"/Views/HO/BaapNetworkDhanuReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    public class Views_HO_BaapNetworkDhanuReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Ho/DhanuNetworkDhanuReport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
  
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
                <li><a href=""#0"">Baap Network Dhanu Coin report</a></li>
            </ol>
        </div>
        <div style=""padding-bottom:20px;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "549d58529249f57d9d8ce8bdca086cfd1c6995884669", async() => {
                WriteLiteral("Please click here to check Dhanu Network Dhanu Coin Report");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""dashboard-center-itm"">
            <div class=""cm-table-data"">
                <div class=""cm-table-data-in"">
                    <table id=""cmDataTable"" class=""display table"" cellspacing=""0"" width=""100%"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Investor ID</th>

                                <th>Mobile</th>
                                <th>Email</th>
                                <th>Dhanu Coin Balance</th>

                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 35 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
                              
                                var i = 0;
                                foreach (DataRow dr in (ViewData["_report"] as DataTable).Rows)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 41 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><span>");
#nullable restore
#line 42 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
                                             Write(dr["LoginId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span>");
#nullable restore
#line 42 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
                                                                                    Write(dr["Name"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n\r\n\r\n                                        <td><p>");
#nullable restore
#line 45 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
                                          Write(dr["Mobile"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 46 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
                                          Write(dr["emailId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        <td><p>");
#nullable restore
#line 47 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
                                          Write(dr["DhanuCoin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 50 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\BaapNetworkDhanuReport.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
