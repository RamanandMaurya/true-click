#pragma checksum "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\UpdateCoinRate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61aa98c040baec52626921ba764b9336bf0182e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HO_UpdateCoinRate), @"mvc.1.0.view", @"/Views/HO/UpdateCoinRate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61aa98c040baec52626921ba764b9336bf0182e0", @"/Views/HO/UpdateCoinRate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    public class Views_HO_UpdateCoinRate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\UpdateCoinRate.cshtml"
  
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
                <li><a href=""#0"">Update Coin Rate</a></li>
            </ol>
        </div>
        <div class=""dashboard-center-itm"">
            <div class=""prasonal-dd shadow-custom"">
");
#nullable restore
#line 17 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\UpdateCoinRate.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""prasonal-form"">
                        <div class=""pre-title-ue"">Set Coin Rate</div>
                        <div class=""form-main"">

                            <div class=""login-intup col-ff5"">
                                <div class=""custom-select"">
                                    <span>Coin</span>
                                    <select id=""coin"" name=""coin"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61aa98c040baec52626921ba764b9336bf0182e05449", async() => {
                WriteLiteral("Choose Coin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61aa98c040baec52626921ba764b9336bf0182e06653", async() => {
                WriteLiteral("Dhanu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61aa98c040baec52626921ba764b9336bf0182e07851", async() => {
                WriteLiteral("Usdt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>

                            <div class=""login-intup col-ff5"">
                                <span>Set Rate (INR)</span>
                                <input type=""text"" name=""amount"" id=""amount"" value=""0"" class=""login-inp"">
                            </div>

                            <div class=""login-intup col-ff5"">
                                &nbsp;
                            </div>

                        </div>
                        <div class=""submit-btn-wrap"">
");
#nullable restore
#line 45 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\UpdateCoinRate.cshtml"
                              
                                string err = "";
                                string errSucc = "";
                                if (ViewData["_ErrorMessage"] != null)
                                {
                                    err = ViewData["_ErrorMessage"].ToString();
                                }
                                if (ViewData["_SuccessMessage"] != null)
                                {
                                    errSucc = ViewData["_SuccessMessage"].ToString();
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label id=\"lblerr\" style=\"color:#cb0f0f\">");
#nullable restore
#line 57 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\UpdateCoinRate.cshtml"
                                                                Write(err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><label id=\"lblsucc\" style=\"color:#376706\">");
#nullable restore
#line 57 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\UpdateCoinRate.cshtml"
                                                                                                                      Write(errSucc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                            <button type=\"submit\" class=\"admin-btn\" id=\"btnSubmit\" name=\"submit\">Submit Request</button>\r\n                            \r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 62 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\HO\UpdateCoinRate.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
