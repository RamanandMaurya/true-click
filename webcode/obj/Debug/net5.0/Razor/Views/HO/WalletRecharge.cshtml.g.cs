#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e44e6d99015e73d6a9681ee73a102032ad25b557"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HO_WalletRecharge), @"mvc.1.0.view", @"/Views/HO/WalletRecharge.cshtml")]
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
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44e6d99015e73d6a9681ee73a102032ad25b557", @"/Views/HO/WalletRecharge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HO_WalletRecharge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
  
    Layout = "~/Views/Shared/_HOLayout.cshtml";
    var _detail = ViewData["_details"] as DataTable;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dss-right-section noside-right-full"">

    <div class=""dashboard-center"">
        <div class=""custom-breadcrumb"">
            <ol class=""cd-breadcrumb"">
                <li><a href=""#"">Dashboard</a></li>
                <li><a href=""#0"">Wallet Fund Recharge</a></li>
            </ol>
        </div>
        <div class=""dashboard-center-itm"">
            <div class=""prasonal-dd shadow-custom"">
");
#nullable restore
#line 18 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""prasonal-form"">
                        <div class=""pre-title-ue"">Wallet Fund Recharge</div>
                        <div class=""form-main"">
                          <div class=""login-intup col-ff5"">
                            <span>Investor Id</span>
                            <input type=""text"" name=""investorid"" id=""investorid"" class=""login-inp""");
            BeginWriteAttribute("value", " value=\"", 1002, "\"", 1037, 1);
#nullable restore
#line 25 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
WriteAttributeValue("", 1010, _detail.Rows[0]["LoginId"], 1010, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly>
                          </div>
                          <div class=""login-intup col-ff5"">
                            <span>Reference no.</span>
                            <input type=""text"" name=""referenceno"" id=""referenceno"" class=""login-inp""");
            BeginWriteAttribute("value", " value=\"", 1301, "\"", 1342, 1);
#nullable restore
#line 29 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
WriteAttributeValue("", 1309, _detail.Rows[0]["TrReferenceno"], 1309, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly>
                          </div>

                          <div class=""login-intup col-ff5"">
                            <span>Dhanu Coin Rate ($)</span>
                            <input type=""text"" name=""dhanurate"" id=""dhanurate"" class=""login-inp""");
            BeginWriteAttribute("value", " value=\"", 1610, "\"", 1645, 1);
#nullable restore
#line 34 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
WriteAttributeValue("", 1618, ViewData["_dhanucoinrate"], 1618, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled>
                          </div>
                          <div class=""login-intup col-ff5"">
                            <span>USDT Coin Rate ($)</span>
                            <input type=""text"" name=""usdtrate"" id=""usdtrate"" class=""login-inp""");
            BeginWriteAttribute("value", " value=\"", 1908, "\"", 1942, 1);
#nullable restore
#line 38 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
WriteAttributeValue("", 1916, ViewData["_usdtcoinrate"], 1916, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                          </div>\r\n\r\n                          <div class=\"login-intup col-ff5\">\r\n                            <span>Add Dhanu Coin</span>\r\n                            <input type=\"text\" name=\"dhanuamount\" id=\"dhanuamount\"");
            BeginWriteAttribute("value", " value=\"", 2191, "\"", 2230, 1);
#nullable restore
#line 43 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
WriteAttributeValue("", 2199, _detail.Rows[0]["DhanuAmount"], 2199, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""login-inp"">
                          </div>
                          <div class=""login-intup col-ff5"" style=""display:none"">
                            <span>Add Dhanu Amount (Crypto Deposit)</span>
                            <input type=""text"" name=""dhanucoin"" id=""dhanucoin"" value=""0"" class=""login-inp"" disabled>
                          </div>

                          <div class=""login-intup col-ff5"">
                            <span>Add USDT Amount (Crypto Deposit)</span>
                            <input type=""text"" name=""usdtamount"" id=""usdtamount""");
            BeginWriteAttribute("value", " value=\"", 2814, "\"", 2852, 1);
#nullable restore
#line 52 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
WriteAttributeValue("", 2822, _detail.Rows[0]["UsdtAmount"], 2822, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""login-inp"">
                          </div>

                          <div class=""login-intup col-ff5"">
                            <span>Add USDT Amount (Trading Pool)</span>
                            <input type=""text"" name=""tpusdtamount"" id=""tpusdtamount""");
            BeginWriteAttribute("value", " value=\"", 3128, "\"", 3168, 1);
#nullable restore
#line 57 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
WriteAttributeValue("", 3136, _detail.Rows[0]["tpUsdtAmount"], 3136, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""login-inp"">
                          </div>
                          <div class=""login-intup col-ff5"" style=""display:none;"">
                            <span>Add USDT Coin</span>
                            <input type=""text"" name=""usdtcoin"" id=""usdtcoin"" value=""0"" class=""login-inp"" disabled>
                          </div>

                          <div class=""login-intup col-ff5"">
                            <span>Total Recharge Coin</span>
                            <input type=""number"" name=""amount"" id=""amount"" value=""0"" class=""login-inp"" disabled>
                          </div>
                          <div class=""login-intup col-ff5"" style=""display:none;"">
                            <span>Payment Receipt</span>
                            <input type=""file"" name=""file"" class=""login-inp"">
                          </div>
                          <div class=""login-intup col-ff5"">
                            <span>Remarks</span>
                            <textarea clas");
            WriteLiteral(@"s=""login-inp text-area"" id=""remark"" name=""remark""></textarea>
                          </div>

                          <div class=""login-intup col-ff5"">
                            <div class=""custom-select"">
                              <span>Status</span>
                              <select id=""status"" name=""status"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e44e6d99015e73d6a9681ee73a102032ad25b55711855", async() => {
                WriteLiteral("Choose Status");
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
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e44e6d99015e73d6a9681ee73a102032ad25b55713054", async() => {
                WriteLiteral("Approve");
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
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e44e6d99015e73d6a9681ee73a102032ad25b55714247", async() => {
                WriteLiteral("Reject");
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

                          <div class=""login-intup col-ff5"" style=""display:none;"">
                            <span>Recharge amount ($)</span>
                            <input type=""number"" class=""login-inp"">
                          </div>
                          <div class=""login-intup col-ff5"" style=""display:none;"">
                            <span>Recharge amount (INR)</span>
                            <input type=""text"" name=""name"" class=""login-inp"" readonly>
                          </div>
                          <div class=""login-intup col-ff5"" style=""display:none;"">
                            <span>Dhanu/USDT Current Exchange Rate (INR)</span>
                            <input type=""text"" name=""name"" class=""login-inp"" readonly>
                          </div>
                          <div class=""login-intup col-ff5"" style=""display:none;"">
                       ");
            WriteLiteral(@"     <span>Estimated Dhanu/USDT Coins</span>
                            <input type=""text"" name=""name"" class=""login-inp"" readonly>
                          </div>

                          <div class=""login-intup col-ff5"">
                            &nbsp;
                          </div>

                        </div>
                        <div class=""submit-btn-wrap"">
");
#nullable restore
#line 111 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
                              
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
#line 118 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
                                                                Write(err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                            <button type=\"submit\" class=\"admin-btn\" id=\"btnSubmit\" name=\"submit\">Submit Request</button>\r\n                            <input type=\"hidden\" id=\"HFregno\" name=\"HFregno\"");
            BeginWriteAttribute("value", " value=\"", 6771, "\"", 6804, 1);
#nullable restore
#line 120 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
WriteAttributeValue("", 6779, _detail.Rows[0]["regno"], 6779, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 123 "D:\codetrx-Laptop\CodeTrex\Projects\true-click\webcode\webcode\Views\HO\WalletRecharge.cshtml"
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

        //DhanuCalc();
        //UsdtCalc();
        TotalCalc();

        $('#dhanuamount').on('change', function () {

            if (!InputMandatory(""dhanuamount"")) {
                alert('Please enter recharge amount. !!');
                return false;
            }

            if (!InputAmountValidate(""dhanuamount"")) {
                alert('Please enter valid recharge amount. !!');
                return false;
            }

            //DhanuCalc();
            TotalCalc();
            return false;
        });

        $('#dhanucoin').on('change', function () {

            if (!InputMandatory(""dhanucoin"")) {
                alert('Please enter recharge amount. !!');
                return false;
            }

            if (!InputAmountValidate(""dhanucoin"")) {
                alert('Please enter valid recharge amount. !!');
                return false;");
            WriteLiteral(@"
            }

            DhanuCalc();
            TotalCalc();
            return false;
        });


        $('#usdtamount').on('change', function () {

            if (!InputMandatory(""usdtamount"")) {
                alert('Please enter recharge amount. !!');
                return false;
            }

            if (!InputAmountValidate(""usdtamount"")) {
                alert('Please enter valid recharge amount. !!');
                return false;
            }

            //UsdtCalc();
            TotalCalc();
            return false;
        });

      $('#tpusdtamount').on('change', function () {

        if (!InputMandatory(""tpusdtamount"")) {
          alert('Please enter recharge amount. !!');
          return false;
        }

        if (!InputAmountValidate(""tpusdtamount"")) {
          alert('Please enter valid recharge amount. !!');
          return false;
        }

        //UsdtCalc();
        TotalCalc();
        return false;
      });

      ");
            WriteLiteral(@"  $('#usdtcoin').on('change', function () {

            if (!InputMandatory(""usdtcoin"")) {
                alert('Please enter recharge amount. !!');
                return false;
            }

            if (!InputAmountValidate(""usdtcoin"")) {
                alert('Please enter valid recharge amount. !!');
                return false;
            }

            //UsdtCalc();
            TotalCalc();
            return false;
        });

        $('#btnSubmit').click(function () {
            $(""#btnSubmit"").hide();
            //$(""#btnSubmit"").attr(""disabled"", true);

            var err = ValidateForm();
            if (err != '') {
                $('#lblerr').text(err);
                $(""#btnSubmit"").show();
                //$(""#btnSubmit"").removeAttr(""disabled"");
                return false;
            }
            return true;
        });
    });

    function DhanuCalc() {

        var _rate = $('#dhanurate').val();
        var _amount = $('#dhanuamount').");
            WriteLiteral(@"val();
        var _coin = $('#dhanucoin').val();

        if (_amount == '') {
            _amount = 0;
        }

        if (_coin == '') {
            _coin = 0;
        }

        if (parseFloat(_amount) > 0) {

            _coin = parseFloat(parseFloat(_amount) / parseFloat(_rate));
        }
        else if (parseFloat(_coin) > 0) {

            _amount = parseFloat(parseFloat(_coin) * parseFloat(_rate));
        }

        $('#dhanuamount').val(_amount);
        $('#dhanucoin').val(_coin);
    }

    function UsdtCalc() {

        var _rate = $('#usdtrate').val();
        var _amount = $('#usdtamount').val();
        var _coin = $('#usdtcoin').val();

        if (_amount == '') {
            _amount = 0;
        }

        if (_coin == '') {
            _coin = 0;
        }

        if (parseFloat(_amount) > 0) {

            _coin = parseFloat(parseFloat(_amount) / parseFloat(_rate));
        }
        else if (parseFloat(_coin) > 0) {

            _amount ");
            WriteLiteral(@"= parseFloat(parseFloat(_coin) * parseFloat(_rate));
        }

        $('#usdtamount').val(_amount);
        $('#usdtcoin').val(_coin);
    }

    function TotalCalc() {

        var _dhanu = $('#dhanuamount').val();
      var _usdt = $('#usdtamount').val();
      var _tpusdt = $('#tpusdtamount').val();

      var _total = parseFloat(parseFloat(_dhanu) + parseFloat(_usdt) + parseFloat(_tpusdt));

        $('#amount').val(_total);
    }

    function ValidateForm() {

        var error = '';
        if (!SelectMandatory(""status"")) {
            error = 'Please choose status. !!';
            return error;
        }

        //if (!InputMandatory(""amount"")) {
        //    error = 'Please enter recharge amount. !!';
        //    return error;
        //}

        //if (!InputAmountValidate(""amount"")) {
        //    error = 'Please enter valid recharge amount. !!';
        //    return error;
        //}
        return error;
    }

    function InputMandatory(name) {
 ");
            WriteLiteral(@"       var val = $('#' + name + '').val();
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
