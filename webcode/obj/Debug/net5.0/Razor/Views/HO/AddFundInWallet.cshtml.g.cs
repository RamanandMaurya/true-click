#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e376a0ef203ea6d57583fe0abcf9bd0b1d8b0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HO_AddFundInWallet), @"mvc.1.0.view", @"/Views/HO/AddFundInWallet.cshtml")]
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
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e376a0ef203ea6d57583fe0abcf9bd0b1d8b0a", @"/Views/HO/AddFundInWallet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HO_AddFundInWallet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml"
  
  Layout = "~/Views/Shared/_HOLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dashboard-center\">\r\n  <div class=\"custom-breadcrumb\">\r\n    <ol class=\"cd-breadcrumb\">\r\n      <li><a href=\"#\">Dashboard</a></li>\r\n      <li><a href=\"#0\">ADD Fund</a></li>\r\n    </ol>\r\n  </div>\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e376a0ef203ea6d57583fe0abcf9bd0b1d8b0a6071", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"      <div class=""dashboard-center-itm"">
        <div class=""prasonal-dd shadow-custom"">
          <div class=""prasonal-form"">
            <div class=""pre-title-ue"">ADD Fund in Wallet</div>
            <div class=""form-main form-main-border"">
              <div class=""login-intup col-ff5"">
                <span>Invester ID</span>
                <input type=""text"" name=""InvesterID"" id=""InvesterID"" class=""login-inp"">
              </div>

              <div class=""login-intup col-ff5"">
                <span>Invester Name</span>
                <input type=""text"" name=""Investorname"" id=""Investorname"" class=""login-inp"" readonly>
              </div>

              <div class=""login-intup col-ff5"">
                <span>Amount Transfer</span>
                <input type=""text"" name=""AmmountTransfer"" id=""AmmountTransfer"" class=""login-inp"">
              </div>
              <div class=""login-intup col-ff5"">
                <div class=""custom-select"">
                  <span>Type of Wallet</spa");
                WriteLiteral("n>\r\n                  <select id=\"WalletType\" name=\"WalletType\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e376a0ef203ea6d57583fe0abcf9bd0b1d8b0a7777", async() => {
                    WriteLiteral("Dhanu");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e376a0ef203ea6d57583fe0abcf9bd0b1d8b0a9019", async() => {
                    WriteLiteral("USDT");
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
                <span>Remark</span>
                <input type=""text"" name=""Remark"" id=""Remark"" class=""login-inp"">
              </div>
              <div class=""login-intup col-ff5"">
                <div class=""edit-p-detail edit-p-detail-padd""><button type=""submit"" class=""admin-btn"" id=""btnsubmit"" value=""btnsubmit"" name=""submit"">Submit</button></div>

");
                WriteLiteral("                <label id=\"lblerr\" style=\"color:#cb0f0f\"></label><br />\r\n              </div>\r\n\r\n              <div class=\"submit-btn-wrap\">\r\n");
#nullable restore
#line 63 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml"
                  
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
                WriteLiteral("                <label id=\"lblerr\" style=\"color:#cb0f0f\">");
#nullable restore
#line 75 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml"
                                                    Write(err);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><label id=\"lblsucc\" style=\"color:#376706\">");
#nullable restore
#line 75 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml"
                                                                                                          Write(errSucc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n\r\n              </div>\r\n\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n");
                WriteLiteral(@"      <div class=""dashboard-center-itm"" style=""display:none;"">
        <div class=""prasonal-dd shadow-custom"">

          <div class=""prasonal-form"">
            <div class=""pre-title-ue"">KYC Info</div>
            <div class=""form-main"">
              <div class=""login-intup has-multiple col-ff"">
                <div class=""pre-title-ue"">Coming Soon. !</div>
              </div>
            </div>
          </div>
        </div>
      </div>
");
#nullable restore
#line 97 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e376a0ef203ea6d57583fe0abcf9bd0b1d8b0a14453", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
  <script>
    $(document).ready(function () {

      $('#btnSubmit').hide();

      $('#InvesterID').on('change', function () {
        GetReferralInfo();
        return false;
      });

      $('#btnsubmit').click(function () {
        var err = ValidateForm();
        if (err != '') {
          $('#lblerr').text(err);
          return false;
        }
        return true;
      });
    });

    function ValidateForm() {
      var error = '';
      if (!InputMandatory(""InvesterID"")) {
        error = 'Please enter InvesterID. !!';
        return error
      }
      if (!InputMandatory(""AmountTransfer"")) {
        error = 'Please enter Ammount. !!';
        return error;
      }

      if (!InputAmountValidate(""AmountTransfer"")) {
        error = 'Invalid Amount. !!';
        return error;
      }
      return error;
    }

    function InputMandatory(name) {
      var val = $('#' + name + '').val();
      if (val == '') {
        return false;
      }
      retu");
            WriteLiteral("rn true;\r\n    };\r\n\r\n\r\n\r\n  function GetReferralInfo() {\r\n\r\n    var loginid = $(\'#InvesterID\').val();\r\n\r\n         $.ajax({\r\n            url: \'");
#nullable restore
#line 154 "D:\codetrx-Laptop\CodeTrex\Projects\new-project\webcode\webcode\Views\HO\AddFundInWallet.cshtml"
             Write(Url.Action("GetMemberDetails", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
             data: { loginid: loginid },
            /*dataType: 'json',*/
             success: function (data) {
               var arr = data.split('$');
               $('#Investorname').val(arr[1]);
               $('#btnSubmit').show();
                 return false;
            }
        });
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

  </script>
");
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