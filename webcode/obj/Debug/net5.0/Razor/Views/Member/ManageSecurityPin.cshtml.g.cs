#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114f72e2835baa87ca3ed708118dd11029c6f971"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_ManageSecurityPin), @"mvc.1.0.view", @"/Views/Member/ManageSecurityPin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114f72e2835baa87ca3ed708118dd11029c6f971", @"/Views/Member/ManageSecurityPin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Member_ManageSecurityPin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
  
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
        <li><a href=""#0"">Manage Security Pin</a></li>
      </ol>
    </div>
    <div class=""dashboard-center-itm"">
      <div class=""prasonal-dd shadow-custom"">
");
#nullable restore
#line 17 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
         using (Html.BeginForm())
        {
          if (ViewData["SecurityPinStatus"] != null)
          {
            if (ViewData["SecurityPinStatus"] == "generate")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              <div id=""divGenerate"" class=""prasonal-form"">
                <div class=""pre-title-ue"">Generate Security Pin</div>
                <div class=""form-main"">
                  <div class=""login-intup col-ff5"">
                    <span>Enter Security Pin</span>
                    <input type=""text"" name=""pin"" id=""pin"" class=""login-inp"">
                  </div>
                  <div class=""login-intup col-ff5"">
                    &nbsp;
                  </div>
                  <div class=""login-intup col-ff5"">
                    <span>Confirm Security Pin</span>
                    <input type=""password"" name=""cpin"" id=""cpin"" class=""login-inp"">
                  </div>
                  <div class=""login-intup col-ff5"">
                    &nbsp;
                  </div>


                </div>
                <div class=""submit-btn-wrap"">
");
#nullable restore
#line 44 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
                    
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
            WriteLiteral("                  <label id=\"lblerr\" style=\"color:#cb0f0f\">");
#nullable restore
#line 57 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
                                                      Write(err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><label id=\"lblsuc\" style=\"color:#eae73f\">");
#nullable restore
#line 57 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
                                                                                                           Write(suc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                  <button type=\"submit\" class=\"admin-btn\" id=\"btnSubmit\" name=\"submit\" value=\"generate\">Generate Security Pin</button>\r\n                </div>\r\n              </div>\r\n");
#nullable restore
#line 61 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              <div id=""divChange"" class=""prasonal-form"">
                <div class=""pre-title-ue"">Change Security Pin</div>
                <div class=""form-main"">
                  <div class=""login-intup col-ff5"">
                    <span>Old Security Pin</span>
                    <input type=""password"" name=""oldpin"" id=""oldpin"" class=""login-inp"">
                  </div>
                  <div class=""login-intup col-ff5"">
                    &nbsp;
                  </div>
                  <div class=""login-intup col-ff5"">
                    <span>New Security Pin</span>
                    <input type=""password"" name=""newpin"" id=""newpin"" class=""login-inp"">
                  </div>
                  <div class=""login-intup col-ff5"">
                    &nbsp;
                  </div>
                  <div class=""login-intup col-ff5"">
                    <span>Confirm Security Pin</span>
                    <input type=""password"" name=""confirmnewpin"" id=""confirmnewpin"" class=""login-");
            WriteLiteral("inp\">\r\n                  </div>\r\n                  <div class=\"login-intup col-ff5\">\r\n                    &nbsp;\r\n                  </div>\r\n\r\n\r\n                </div>\r\n                <div class=\"submit-btn-wrap\">\r\n");
#nullable restore
#line 92 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
                    
                    string err2 = "";
                    string suc2 = "";
                    if (ViewData["_ErrorMessage"] != null)
                    {
                      err2 = ViewData["_ErrorMessage"].ToString();
                    }

                    if (ViewData["_SuccessMessage"] != null)
                    {
                      suc2 = ViewData["_SuccessMessage"].ToString();
                    }
                  

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <label id=\"lblerr2\" style=\"color:#cb0f0f\">");
#nullable restore
#line 105 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
                                                       Write(err2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><label id=\"lblsuc2\" style=\"color:#eae73f\">");
#nullable restore
#line 105 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
                                                                                                              Write(suc2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label><br />
                  <button type=""submit"" class=""admin-btn"" id=""btnSubmit2"" name=""submit"" value=""change"">Change Security Pin</button>
                  <br /><br />OR<br /><br />
                  <button type=""submit"" class=""admin-btn"" id=""btnSubmit3"" name=""submit"" value=""forgot"">Forgot Security Pin</button>
                </div>
              </div>
");
#nullable restore
#line 111 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\Member\ManageSecurityPin.cshtml"
            }
          }



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
      var err = ValidateForm();
      if (err != '') {
        $('#lblerr').text(err);
        return false;
      }
      return true;
    });

    $('#btnSubmit2').click(function () {
      var err = ValidateForm2();
      if (err != '') {
        $('#lblerr2').text(err);
        return false;
      }
      return true;
    });
  });

  function ValidateForm() {

    var error = '';
    if (!InputMandatory(""pin"")) {
      error = 'Please enter security pin. !!';
      return error;
    }

    if (!InputMandatory(""cpin"")) {
      error = 'Please enter confirm security pin. !!';
      return error;
    }

    if ($('#pin').val().length != 6) {
      error = 'Please enter 6 digit security pin. !!';
      return error;
    }

    if ($('#pin').val().trim() != $('#cpin').val().trim()) {
      error = 'Entered pin and confirm pin did not m");
            WriteLiteral(@"atch. !!';
      return error;
    }
    return error;
  }

  function ValidateForm2() {

    var error = '';
    if (!InputMandatory(""oldpin"")) {
      error = 'Please enter old security pin. !!';
      return error;
    }

    if (!InputMandatory(""newpin"")) {
      error = 'Please enter new security pin. !!';
      return error;
    }

    if ($('#newpin').val().length != 6) {
      error = 'Please enter 6 digit new security pin. !!';
      return error;
    }

    if (!InputMandatory(""confirmnewpin"")) {
      error = 'Please confirm new security pin. !!';
      return error;
    }

    if ($('#newpin').val().trim() != $('#confirmnewpin').val().trim()) {
      error = 'Entered pin and confirm pin did not match. !!';
      return error;
    }
    return error;
  }
  function InputMandatory(name) {
    var val = $('#' + name + '').val();
    if (val == '') {
      return false;
    }
    return true;
  }

  function InputAmountValidate(name) {
    var val = $('#' + ");
            WriteLiteral(@"name + '').val();
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
