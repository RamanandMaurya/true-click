#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ed2c6ce20d9357ec2eb794dd3413ab9e88ffb81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_WithdrawalEligible), @"mvc.1.0.view", @"/Views/Member/WithdrawalEligible.cshtml")]
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
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ed2c6ce20d9357ec2eb794dd3413ab9e88ffb81", @"/Views/Member/WithdrawalEligible.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Member_WithdrawalEligible : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-button-tbl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Member/OtpAuthentication/2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
  
    Layout = "~/Views/Shared/_MemberLayout.cshtml";
    var details = ViewData["_details"] as DataTable;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""dss-right-section noside-right-full"">
    <div class=""dashboard-center"">
        <div class=""custom-breadcrumb"">
            <ol class=""cd-breadcrumb"">
                <li><a href=""#"">Dashboard</a></li>
                <li><a href=""#0"">withdrawal</a></li>
            </ol>
        </div>
        <div class=""dashboard-center-itm"">
            <div class=""community-wrapper shadow-custom"">
                <div class=""withdrawl"">
                    <div class=""withdralw_inner"">
                        <div class=""dhanuWithdrawl dhanulftSection"">
                            <div class=""liveDhanuTitle"">DHANU</div>
                            <div class=""coinDesign"">
                                <img src=""/assets_backend/images/withdrawalDhanu.png"" alt=""dhanu images"" />
                            </div>
                            <div class=""liveRate"">
                                <table>
                                    <tbody>
                                        ");
            WriteLiteral("<tr>\r\n                                            <td>Withdraw Eligible Coin</td>\r\n                                            <td>");
#nullable restore
#line 31 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                           Write(details.Rows[0]["DhanuWithdrawBalanceCoin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td>Withdraw Eligible Amount($)</td>\r\n                                            <td>$ ");
#nullable restore
#line 35 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                             Write(details.Rows[0]["DhanuWithdrawBalanceUsd"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            WriteLiteral("                                        <tr>\r\n                                            <td colspan=\"2\" style=\"text-align: center\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ed2c6ce20d9357ec2eb794dd3413ab9e88ffb817042", async() => {
                WriteLiteral("Click here to submit withdrawal request");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </td>
                                        </tr>
                                    <tbody>
                                </table>
                            </div>
                        </div>
                        <div class=""dhanuWithdrawl USDTRightSection"">
                            <div class=""liveDhanuTitle"">USDT</div>
                            <div class=""coinDesign"">
                                <img src=""/assets_backend/images/withdrawalUSDT.png"" alt=""USDT images"" />
                            </div>
                            <div class=""liveRate"">
                                <table>
                                    <tbody>
                                        <tr>
                                            <td>Withdraw Eligible Coin</td>
                                            <td>");
#nullable restore
#line 72 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                           Write(details.Rows[0]["UsdtWithdrawBalanceCoin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td>Withdraw Eligible Amount($)</td>\r\n                                            <td>$ ");
#nullable restore
#line 76 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                             Write(details.Rows[0]["UsdtWithdrawBalanceUsd"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            WriteLiteral("                                    <tbody>\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""dashboard-center-itm"">
            <div class=""community-wrapper shadow-custom"">
                <div class=""widthdrawlTblWrp"">
                    <div class=""widthdrawlTblWrpIn"">
                        <div class=""wthdrebtn current"" data-elgible=""elgible"">DHANU</div>
                        <div class=""wthdrebtn"" data-elgible=""elgible1"">USDT</div>
                    </div>
                </div>
                <div class=""withdrawlTbl"">
                    <div class=""cm-table-data tableTabStyle current"" id=""elgible"">
                        <div class=""cm-table-data-in"">
                            <table id=""cmDataTable"" class=""display table"" cellspacing=""0"" width=""100%"">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Tr. Date</th>
                                        <th>Tr. Na");
            WriteLiteral(@"me</th>
                                        <th>Credit Coin</th>
                                        <th>Used Coin</th>
                                        <th>Bal. Coin</th>
                                        <th>Used Status</th>
                                        <th>Withdraw Status</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 153 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                      
                                        var i = 0;
                                        foreach (DataRow dr in (ViewData["_dhanureport"] as DataTable).Rows)
                                        {
                                            i++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 160 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><p>");
#nullable restore
#line 161 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["TrDate"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 162 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["TrName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 163 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["Coin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 164 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["UsedCoin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 165 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["BalanceCoin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 166 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["BalanceStatus"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 167 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["EligibleStatus"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 169 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>

                    <div class=""cm-table-data tableTabStyle"" id=""elgible1"">
                        <div class=""cm-table-data-in"">
                            <table id=""cmDataTable2"" class=""display table"" cellspacing=""0"" width=""100%"">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Tr. Date</th>
                                        <th>Tr. Name</th>
                                        <th>Credit Coin</th>
                                        <th>Used Coin</th>
                                        <th>Bal. Coin</th>
                                        <th>Used Status</th>
                                        <th>Withdraw Status</th>
                                    </tr>
                                </t");
            WriteLiteral("head>\r\n                                <tbody>\r\n");
#nullable restore
#line 193 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                      
                                        var j = 0;
                                        foreach (DataRow dr in (ViewData["_usdtreport"] as DataTable).Rows)
                                        {
                                            j++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 200 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                           Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><p>");
#nullable restore
#line 201 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["TrDate"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 202 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["TrName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 203 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["Coin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 204 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["UsedCoin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 205 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["BalanceCoin"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 206 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["BalanceStatus"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td><p>");
#nullable restore
#line 207 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                              Write(dr["EligibleStatus"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 209 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\WithdrawalEligible.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
