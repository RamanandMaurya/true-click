#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\OtpAuthentication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db7bcdcefdc99af2f82b404d368c487e36bf6f61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_OtpAuthentication), @"mvc.1.0.view", @"/Views/Member/OtpAuthentication.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db7bcdcefdc99af2f82b404d368c487e36bf6f61", @"/Views/Member/OtpAuthentication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Member_OtpAuthentication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\OtpAuthentication.cshtml"
  
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
                <li><a href=""#0"">OTP Authentication</a></li>
            </ol>
        </div>
        <div class=""dashboard-center-itm"">
            <div class=""prasonal-dd shadow-custom"">
");
#nullable restore
#line 17 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\OtpAuthentication.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""prasonal-form"">
                        <div class=""pre-title-ue"">Authenticate OTP</div>
                        <div class=""form-main"">
                            <div class=""login-intup col-ff5"">
                                * Please verify your OTP sent on your registered email address with us.!!
                            </div>
                            <div class=""login-intup col-ff5"">
                                &nbsp;
                            </div>
                            <div class=""login-intup col-ff5"">
                                <span>Enter OTP Code</span>
                                <input type=""text"" name=""otp"" id=""otp"" class=""login-inp"">
                            </div>
                            <div class=""login-intup col-ff5"">
                                &nbsp;
                            </div>
                        </div>
                        <div class=""submit-btn-wrap"">
");
#nullable restore
#line 37 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\OtpAuthentication.cshtml"
                              
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
            WriteLiteral("                            <label id=\"lblerr\" style=\"color:#cb0f0f\">");
#nullable restore
#line 50 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\OtpAuthentication.cshtml"
                                                                Write(err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><label id=\"lblsuc\" style=\"color:#eae73f\">");
#nullable restore
#line 50 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\OtpAuthentication.cshtml"
                                                                                                                     Write(suc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                            <button type=\"submit\" class=\"admin-btn\" id=\"btnSubmit\" name=\"submit\">Verify OTP</button>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 54 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\OtpAuthentication.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
