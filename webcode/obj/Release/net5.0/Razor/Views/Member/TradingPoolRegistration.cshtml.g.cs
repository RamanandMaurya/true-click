#pragma checksum "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\TradingPoolRegistration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab7c6f2a4d4ef78924d4072d7aa6a8f2b8ff48a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_TradingPoolRegistration), @"mvc.1.0.view", @"/Views/Member/TradingPoolRegistration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab7c6f2a4d4ef78924d4072d7aa6a8f2b8ff48a1", @"/Views/Member/TradingPoolRegistration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_TradingPoolRegistration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\TradingPoolRegistration.cshtml"
  
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
        <li><a href=""#0"">Register In Trading Pool</a></li>
      </ol>
    </div>
    <div class=""dashboard-center-itm"">
      <div class=""prasonal-dd shadow-custom"">
");
#nullable restore
#line 16 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\TradingPoolRegistration.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <div class=""prasonal-form"">
            <div class=""pre-title-ue"">Register Yourself In Trading Pool</div>
            <div class=""form-main"">
              <div class=""login-intup col-ff5"">
                <span>Referal Id</span>
                <input type=""text"" name=""investorloginid"" id=""investorloginid"" class=""login-inp"">
              </div>
              <div class=""login-intup col-ff5"">
                <span>Referal Name</span>
                <input type=""text"" name=""investorname"" id=""investorname"" class=""login-inp"" readonly>
              </div>

            </div>
            <div class=""submit-btn-wrap text-align-left"">
");
#nullable restore
#line 32 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\TradingPoolRegistration.cshtml"
                
                string err = "";
                string suc = "";
                if (ViewData["_ErrorMessage"] != null)
                {
                  err = ViewData["_ErrorMessage"].ToString();
                }

                if (ViewData["_SuccessMessage"] != null)
                {
                  suc = ViewData["_SuccessMessage"].ToString();
                }
              

#line default
#line hidden
#nullable disable
            WriteLiteral("              <label id=\"lblerr\" style=\"color:#cb0f0f\">");
#nullable restore
#line 45 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\TradingPoolRegistration.cshtml"
                                                  Write(err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><label id=\"lblsuc\" style=\"color:#eae73f\">");
#nullable restore
#line 45 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\TradingPoolRegistration.cshtml"
                                                                                                       Write(suc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n              <button type=\"submit\" class=\"admin-btn\" id=\"btnSubmit\" name=\"btnSubmit\">Register</button>\r\n            </div>\r\n          </div>\r\n");
#nullable restore
#line 49 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\TradingPoolRegistration.cshtml"

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

    $('#btnSubmit').hide();

    $('#investorloginid').on('change', function () {

      GetReferralInfo();
      return false;
    });

    $('#btnSubmit').click(function () {

      $(""#btnSubmit"").hide();

      var err = '';
      if (err != '') {
        $('#lblerr').text(err);
        $(""#btnSubmit"").show();
        return false;
      }
      return true;
    });
  });


  function ValidateForm() {

    var error = '';

    if (!InputMandatory(""investorloginid"")) {
      error = 'Please enter Invester id. !!';
      return error;
    }

    return error;
  }

  function GetReferralInfo() {

        var LoginId = $('#investorloginid').val();

         $.ajax({
            url: '");
#nullable restore
#line 103 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\TradingPoolRegistration.cshtml"
             Write(Url.Action("GetMemberDetails", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
             data: { LoginId: LoginId },
            dataType: 'json',
             success: function (data) {
               var arr = data.split('$');
               $('#investorname').val(arr[1]);
               $('#btnSubmit').show();
                 return false;
            }
        });
    }

  function InputMandatory(name) {
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
