#pragma checksum "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "467b6660fadf9d280fd1f2c3ce1d9fd018d3a533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Profile), @"mvc.1.0.view", @"/Views/Member/Profile.cshtml")]
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
#line 1 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"467b6660fadf9d280fd1f2c3ce1d9fd018d3a533", @"/Views/Member/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
  
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

    var _profile = ViewData["_Profiledetails"] as DataTable;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dashboard-center\">\r\n    <div class=\"custom-breadcrumb\">\r\n        <ol class=\"cd-breadcrumb\">\r\n            <li><a href=\"#\">Dashboard</a></li>\r\n            <li><a href=\"#0\">Profile</a></li>\r\n        </ol>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""dashboard-center-itm"">

            <div class=""prasonal-dd shadow-custom"">

                <div class=""prasonal-form"">
                    <div class=""pre-title-ue"">Personal Info</div>
                    <div class=""form-main"">
                        <div class=""login-intup col-ff5"">
                            <span>First Name</span>
                            <input type=""text"" name=""firstname"" id=""firstname""");
            BeginWriteAttribute("value", " value=\"", 891, "\"", 929, 1);
#nullable restore
#line 27 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 899, _profile.Rows[0]["Firstname"], 899, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"login-inp\" readonly>\r\n                        </div>\r\n                        <div class=\"login-intup col-ff5\">\r\n                            <span>Last Name</span>\r\n                            <input type=\"text\" name=\"lastname\" id=\"lastname\"");
            BeginWriteAttribute("value", " value=\"", 1179, "\"", 1216, 1);
#nullable restore
#line 31 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 1187, _profile.Rows[0]["Lastname"], 1187, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"login-inp\" readonly>\r\n                        </div>\r\n                        <div class=\"login-intup col-ff5\">\r\n                            <span>Email</span>\r\n                            <input type=\"text\" name=\"email\" id=\"email\"");
            BeginWriteAttribute("value", " value=\"", 1456, "\"", 1490, 1);
#nullable restore
#line 35 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 1464, _profile.Rows[0]["Email"], 1464, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""login-inp"">
                        </div>
                        <div class=""login-intup col-ff5"" style=""display:none;"">
                            <span>Date of Birth</span>
                            <input type=""date"" name=""dob"" id=""dob""");
            BeginWriteAttribute("value", " value=\"", 1747, "\"", 1787, 1);
#nullable restore
#line 39 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 1755, _profile.Rows[0]["Dateofbirth"], 1755, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"login-inp\">\r\n                        </div>\r\n                        <div class=\"login-intup col-ff5\">\r\n                            <span>Contact No</span>\r\n                            <input type=\"text\" name=\"mobile\" id=\"mobile\"");
            BeginWriteAttribute("value", " value=\"", 2025, "\"", 2060, 1);
#nullable restore
#line 43 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 2033, _profile.Rows[0]["Mobile"], 2033, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""login-inp"" readonly>
                        </div>
                        <div class=""login-intup col-ff5"">
                            <div class=""custom-select"">
                                <span>Gender</span>
                                <select id=""gender"" name=""gender"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467b6660fadf9d280fd1f2c3ce1d9fd018d3a5338825", async() => {
                WriteLiteral("Male");
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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467b6660fadf9d280fd1f2c3ce1d9fd018d3a53310018", async() => {
                WriteLiteral("Female");
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
                            <div class=""edit-p-detail""><button type=""submit"" class=""admin-btn"" id=""btnSubmit"" name=""submit"">Update</button></div>
                            <br />
");
#nullable restore
#line 57 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
                              
                                string err = "";
                                if (ViewData["_ErrorMessage"] != null)
                                {
                                    err = ViewData["_ErrorMessage"].ToString();
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label id=\"lblerr\" style=\"color:#cb0f0f\">");
#nullable restore
#line 64 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
                                                                Write(err);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label><br />
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class=""dashboard-center-itm"" style=""display:none;"">
            <div class=""col6-form"">
                <div class=""form-col-w col-ff5"">
                    <div class=""prasonal-dd shadow-custom"">
                        <div class=""prasonal-form"">
                            <div class=""pre-title-ue"">Nominee Info</div>
                            <div class=""form-main"">
                                <div class=""login-intup col-ff"">
                                    <span>Name</span>
                                    <input type=""text"" name=""nomineename"" id=""nomineename""");
            BeginWriteAttribute("value", " value=\"", 4005, "\"", 4045, 1);
#nullable restore
#line 80 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 4013, _profile.Rows[0]["Nomineename"], 4013, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""login-inp"">
                                </div>
                                <div class=""login-intup col-ff"">
                                    <span>Relation</span>
                                    <input type=""text"" name=""nomineerelation"" id=""nomineerelation""");
            BeginWriteAttribute("value", " value=\"", 4330, "\"", 4374, 1);
#nullable restore
#line 84 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 4338, _profile.Rows[0]["Nomineerelation"], 4338, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""login-inp"">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""form-col-w col-ff5"">
                    <div class=""prasonal-dd shadow-custom"">
                        <div class=""prasonal-form"">
                            <div class=""pre-title-ue"">Sponsor Info</div>
                            <div class=""form-main"">
                                <div class=""login-intup col-ff"">
                                    <span>Sponsor Name</span>
                                    <input type=""text"" name=""sponsorname"" id=""sponsorname""");
            BeginWriteAttribute("value", " value=\"", 5066, "\"", 5106, 1);
#nullable restore
#line 97 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 5074, _profile.Rows[0]["Sponsorname"], 5074, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""login-inp"" readonly>
                                </div>
                                <div class=""login-intup col-ff"">
                                    <span>Sponsor ID</span>
                                    <input type=""text"" name=""sponsorid"" id=""sponsorid""");
            BeginWriteAttribute("value", " value=\"", 5390, "\"", 5428, 1);
#nullable restore
#line 101 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 5398, _profile.Rows[0]["SponsorId"], 5398, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"login-inp\" readonly>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""dashboard-center-itm"" style=""display:none;"">
            <div class=""prasonal-dd shadow-custom"">

                <div class=""prasonal-form"">
                    <div class=""pre-title-ue"">Address</div>
                    <div class=""form-main"">
                        <div class=""login-intup has-multiple col-ff5"">
                            <div class=""login-intup-inner"">
                                <span>Address Info</span>
                                <textarea class=""login-inp text-area"" name=""address"" id=""address"">");
#nullable restore
#line 121 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
                                                                                             Write(_profile.Rows[0]["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                            </div>
                            <div class=""login-intup-inner"">
                                <div class=""custom-select"">
                                    <span>Country</span>
                                    <select id=""country"" name=""country"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467b6660fadf9d280fd1f2c3ce1d9fd018d3a53317727", async() => {
                WriteLiteral("--Select--");
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
            WriteLiteral("\r\n");
#nullable restore
#line 128 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
                                         foreach (DataRow dr in (ViewData["_country"] as DataTable).Rows)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467b6660fadf9d280fd1f2c3ce1d9fd018d3a53319301", async() => {
#nullable restore
#line 130 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
                                                                             Write(dr["Countryname"].ToString());

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
                                               WriteLiteral(dr["cid"].ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 131 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class=""login-intup has-multiple col-ff5"">
                            <div class=""login-intup-inner"">
                                <span>State Name</span>
                                <input type=""text"" name=""statename"" id=""statename""");
            BeginWriteAttribute("value", " value=\"", 7375, "\"", 7413, 1);
#nullable restore
#line 139 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 7383, _profile.Rows[0]["Statename"], 7383, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""login-inp"">
                            </div>
                            <div class=""login-intup-inner has-select"">
                                <span>City Name</span>
                                <input type=""text"" name=""cityname"" id=""cityname""");
            BeginWriteAttribute("value", " value=\"", 7679, "\"", 7716, 1);
#nullable restore
#line 143 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 7687, _profile.Rows[0]["Cityname"], 7687, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"login-inp\">\r\n                            </div>\r\n                            <div class=\"login-intup-inner\">\r\n                                <span>Pin Code</span>\r\n                                <input type=\"text\" name=\"pincode\" id=\"pincode\"");
            BeginWriteAttribute("value", " value=\"", 7968, "\"", 8004, 1);
#nullable restore
#line 147 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 7976, _profile.Rows[0]["Pincode"], 7976, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"login-inp\">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""dashboard-center-itm"">
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
        <input type=""hidden"" id=""Hf_Gender""");
            BeginWriteAttribute("value", " value=\"", 8745, "\"", 8780, 1);
#nullable restore
#line 168 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 8753, _profile.Rows[0]["Gender"], 8753, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\" id=\"Hf_Country\"");
            BeginWriteAttribute("value", " value=\"", 8830, "\"", 8868, 1);
#nullable restore
#line 169 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
WriteAttributeValue("", 8838, _profile.Rows[0]["Countryid"], 8838, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 170 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\Profile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script>
    $(document).ready(function () {

        var Gender = $('#Hf_Gender').val();
        var CountryId = $('#Hf_Country').val();

        $('#gender').val(Gender);
        $('#country').val(CountryId);


        $('#btnSubmit').click(function () {
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
        if (!InputMandatory(""fname"")) {
            error = 'Please enter first name. !!';
            return error;
        }

        if (!InputMandatory(""email"")) {
            error = 'Please enter email id. !!';
            return error;
        }

        if (!InputEmailValidate(""email"")) {
            error = 'Please enter valid email id. !!';
            return error;
        }

        if (!InputMandatory(""mobile"")) {
            error = 'Please e");
            WriteLiteral(@"nter mobile no. !!';
            return error;
        }

        if (!InputMobileValidate(""mobile"")) {
            error = 'Please enter valid mobile no. !!';
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

    function InputEmailValidate(name) {
        var val = $('#' + name + '').val();
        var emailReg = /^([\w-\.]+");
            WriteLiteral(@"@([\w-]+\.)+[\w-]{2,4})?$/;
        return emailReg.test(val);
    }

    function InputMobileValidate(name) {
        var val = $('#' + name + '').val();
        var len = val.length;
        if (len != 10) {
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
