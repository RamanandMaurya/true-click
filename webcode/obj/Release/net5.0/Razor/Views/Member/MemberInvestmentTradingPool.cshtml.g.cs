#pragma checksum "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\MemberInvestmentTradingPool.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9adfb4a62105baccef24961834bc9dc8b03383ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_MemberInvestmentTradingPool), @"mvc.1.0.view", @"/Views/Member/MemberInvestmentTradingPool.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9adfb4a62105baccef24961834bc9dc8b03383ff", @"/Views/Member/MemberInvestmentTradingPool.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_MemberInvestmentTradingPool : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\MemberInvestmentTradingPool.cshtml"
  
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
        <li><a href=""#0"">Manage Trading Pool Investment</a></li>
      </ol>
    </div>
    <div class=""dashboard-center-itm"">
      <div class=""prasonal-dd shadow-custom"">
");
#nullable restore
#line 16 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\MemberInvestmentTradingPool.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <div class=""prasonal-form"">
            <div class=""pre-title-ue"">Manage Investment</div>
            <div class=""form-main"">
              <div class=""login-intup col-ff5"">
                <span>Usdt Wallet Balance</span>
                <input type=""text"" name=""usdtBalance"" id=""usdtBalance"" class=""login-inp""");
            BeginWriteAttribute("value", " value=\"", 812, "\"", 845, 1);
#nullable restore
#line 23 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\MemberInvestmentTradingPool.cshtml"
WriteAttributeValue("", 820, ViewData["_usdtbalance"], 820, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly>
              </div>
              <div class=""login-intup col-ff5"">
              </div>
              <div class=""login-intup col-ff5"">
                <div class=""custom-select"">
                  <span>Payment Type</span>
                  <select id=""paymenttype"" name=""paymenttype"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9adfb4a62105baccef24961834bc9dc8b03383ff5853", async() => {
                WriteLiteral("Choose Payment Type");
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9adfb4a62105baccef24961834bc9dc8b03383ff7045", async() => {
                WriteLiteral("100 % USDT");
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
            WriteLiteral(@"
                  </select>
                </div>
              </div>
              <div class=""login-intup col-ff5"">
                <span>Investment Amount</span>
                <input type=""number"" name=""amount"" id=""amount"" class=""login-inp"">
              </div>
              <div class=""login-intup col-ff"">
                <span class=""investmentTitle"">Choose Plan</span>
                <div class=""selectInvestment"">
                  <div class=""investmentItem""><input type=""radio"" checked id=""Plan1"" name=""investmentType"" value=""6"" /><label for=""Plan1"">USDT 100 - 10000 (4% ROI)</label></div>
                  <div class=""investmentItem""><input type=""radio"" id=""Plan2"" name=""investmentType"" value=""7"" /><label for=""Plan2"">USDT 10100 - 17500 (5% ROI)</label></div>
                  <div class=""investmentItem""><input type=""radio"" id=""Plan3"" name=""investmentType"" value=""8"" /><label for=""Plan3"">USDT 17600 Above (6% ROI)</label></div>
                </div>
              </div>


          ");
            WriteLiteral("  </div>\r\n            <div class=\"submit-btn-wrap\">\r\n");
#nullable restore
#line 52 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\MemberInvestmentTradingPool.cshtml"
                
                string err = "";
                if (ViewData["_ErrorMessage"] != null)
                {
                  err = ViewData["_ErrorMessage"].ToString();
                }
              

#line default
#line hidden
#nullable disable
            WriteLiteral("              <label id=\"lblerr\" style=\"color:#cb0f0f\">");
#nullable restore
#line 59 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\MemberInvestmentTradingPool.cshtml"
                                                  Write(err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n              <button type=\"submit\" class=\"admin-btn\" id=\"btnSubmit\" name=\"submit\">Save Investment</button>\r\n            </div>\r\n          </div>\r\n");
#nullable restore
#line 63 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\MemberInvestmentTradingPool.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
      </div>
    </div>

  </div>

</div>

<script>
    $(document).ready(function () {

        $('#btnSubmit').click(function () {

            //$(""#btnSubmit"").attr(""disabled"", true);
            $(""#btnSubmit"").hide();

            var err = ValidateForm();
            if (err != '') {
                $('#lblerr').text(err);
                $(""#btnSubmit"").show();
                //$(""#btnSubmit"").removeAttr(""disabled"");
                return false;
            }

            if (!confirm('Are you sure to invest in Trading Pool ?')) {
                $(""#btnSubmit"").show();
                return false;
            }

            return true;
        });
    });

    function ValidateForm() {

        var error = '';

        if (!SelectMandatory(""paymenttype"")) {
            error = 'Please choose payment type. !!';
            return error;
        }

        if (!InputMandatory(""amount"")) {
            error = 'Please enter investment amount. !!';
        ");
            WriteLiteral(@"    return error;
        }

        if (!InputAmountValidate(""amount"")) {
            error = 'Please enter valid investment amount. !!';
            return error;
      }

      var amt = $('#amount').val();
      var plan = $(""input[name='investmentType']:checked"").val();

      if (plan == '6') {
        if (parseFloat(amt) < 100 || parseFloat(amt) > 10000) {
          error = 'Please enter valid investment amount. Amount should be between 100 - 10000 !!';
          return error;
        }
      }

      if (plan == '7') {
        if (parseFloat(amt) < 10100 || parseFloat(amt) > 17500) {
          error = 'Please enter valid investment amount. Amount should be between 10100 - 17500 !!';
          return error;
        }
      }

      if (plan == '8') {
        if (parseFloat(amt) < 17600) {
          error = 'Please enter valid investment amount. Amount should be above 17600 !!';
          return error;
        }
      }
        return error;
    }

    function InputMan");
            WriteLiteral(@"datory(name) {
        var val = $('#' + name + '').val();
        if (val == '') {
            return false;
        }
        return true;
    }

    function InputAmountValidate(name) {
        var val = $('#' + name + '').val();
        if (parseFloat(val) <= 0) {
            return false;
        }
        return true;
    }

    function SelectMandatory(name) {
        var val = $('#' + name + '').val();
        if (val == 0) {
            return false;
        }
        return true;
    }
</script>");
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
