#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\UsdtTransfer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "863b0df6b1de80e37ed15bfe4481df688601f9b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_UsdtTransfer), @"mvc.1.0.view", @"/Views/Member/UsdtTransfer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863b0df6b1de80e37ed15bfe4481df688601f9b2", @"/Views/Member/UsdtTransfer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Member_UsdtTransfer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\UsdtTransfer.cshtml"
  
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
        <li><a href=""#0"">USDT Transfer From Dhanu Pool To Trading Pool</a></li>
      </ol>
    </div>
    <div class=""dashboard-center-itm"">
      <div class=""prasonal-dd shadow-custom"">
");
#nullable restore
#line 16 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\UsdtTransfer.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <div class=""prasonal-form"">
            <div class=""pre-title-ue"">Fund Transfer (From Dhanu Pool To Trading Pool)</div>
            
            <div class=""fundFormWrap"">
              
              <div class=""fundType mt-adds"">
                <div class=""fundDesign usdtFund""><img src=""/assets_backend/images/usdt.png"" alt=""logo""> USDT (Crypto Deposit)</div>
              </div>

              <div class=""formWithQR"">
                <div class=""mainQRCode hideMobile"">

                </div>
                <div class=""form-main no-flex"">
                  <div id=""divUsdt"" class=""login-intup col-ff-maxL"">
");
            WriteLiteral("                    <div class=\"all-lbl-inp threeInp\">\r\n                      <div class=\"single-row-inp\">\r\n                        <span>Balance (Coin)</span>\r\n                        <label class=\"login-inp\">");
#nullable restore
#line 37 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\UsdtTransfer.cshtml"
                                            Write(ViewData["_usdtbalance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                      </div>
                    </div>
                    <div class=""all-lbl-inp threeInp"">
                      <div class=""single-row-inp"">
                        <span>Coins</span>
                        <input type=""number"" name=""usdtcoin"" id=""usdtcoin""");
            BeginWriteAttribute("value", " value=\"", 1731, "\"", 1739, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter amount"" class=""login-inp color-yellow"" autocomplete=""off"">
                      </div>
                      <div class=""single-row-inp"">
                        <span>Amount ($)</span>
                        <input type=""text"" name=""usdtamount"" id=""usdtamount"" value=""0"" class=""login-inp"" disabled>
                      </div>
                      <div class=""single-row-inp"">
                        <span>Amount <label>(<img src=""/assets_backend/images/rupees.png"" alt=""logo"">)</label></span>
                        <input type=""number"" name=""usdtcurrency"" id=""usdtcurrency"" value=""0"" class=""login-inp color-red"" disabled>
                      </div>
                    </div>
                  </div>

                  <div class=""login-intup col-ff-maxL"">
                    <div class=""all-lbl"">Remark</div>
                    <textarea class=""login-inp text-area"" id=""remark"" name=""remark""></textarea>
                  </div>
                  <div class=""submit-btn-wr");
            WriteLiteral("ap text-align-left\">\r\n");
#nullable restore
#line 61 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\UsdtTransfer.cshtml"
                      
                      string err2 = "";
                      if (ViewData["_ErrorMessage"] != null)
                      {
                        err2 = ViewData["_ErrorMessage"].ToString();
                      }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label id=\"lblerrUsdt\" style=\"color:#cb0f0f\">");
#nullable restore
#line 68 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\UsdtTransfer.cshtml"
                                                            Write(err2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label><br />
                    <button type=""submit"" class=""admin-btn"" id=""btnSubmit"" name=""btnSubmit"">Submit Coin Transfer</button>
                  </div>
                </div>
              </div>

              

              <div class=""formWithQR"">
                <div class=""form-main no-flex"">
                  
                </div>
              </div>
            </div>


            <div class=""submit-btn-wrap text-align-left"">
              <input type=""hidden"" name=""usdtrate"" id=""usdtrate""");
            BeginWriteAttribute("value", " value=\"", 3659, "\"", 3693, 1);
#nullable restore
#line 85 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\UsdtTransfer.cshtml"
WriteAttributeValue("", 3667, ViewData["_usdtcoinrate"], 3667, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n              <input type=\"hidden\" name=\"currencyrate\" id=\"currencyrate\"");
            BeginWriteAttribute("value", " value=\"", 3769, "\"", 3803, 1);
#nullable restore
#line 86 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\UsdtTransfer.cshtml"
WriteAttributeValue("", 3777, ViewData["_currencyrate"], 3777, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n          </div>\r\n");
#nullable restore
#line 89 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\Member\UsdtTransfer.cshtml"

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

    $('#usdtamount').on('change', function () {

      if (!InputMandatory(""usdtamount"")) {
        $('#usdtamount').val('0');
        $('#usdtcoin').val('0');
      }

      if (!InputAmountValidate(""usdtamount"")) {
        $('#usdtamount').val('0');
        $('#usdtcoin').val('0');
      }

      UsdtCalc();
      return false;
    });

    $('#usdtcoin').on('change', function () {
      
      if (!InputMandatory(""usdtcoin"")) {
        $('#usdtcoin').val('0');
        $('#usdtamount').val('0');
      }

      if (!InputAmountValidate(""usdtcoin"")) {
        $('#usdtcoin').val('0');
        $('#usdtamount').val('0');
      }

      UsdtCalc();
      return false;
    });

    $('#btnSubmit').click(function () {

      $(""#btnSubmit"").hide();

      var err = '';
      if (err != '') {
        $('#lblerr').text(err);
        $(""#btnSubmit"").show();
        return false;");
            WriteLiteral(@"
      }
      return true;
    });
  });

  function UsdtCalc() {

    var _rate = $('#usdtrate').val();
    var _amount = $('#usdtamount').val();
    var _coin = $('#usdtcoin').val();
    var _currencyrate = $('#currencyrate').val();
    var _currencyamount = 0;

    if (_amount == '') {
      _amount = 0;
    }

    if (_coin == '') {
      _coin = 0;
    }

    if (_currencyrate == '') {
      _currencyrate = 0;
    }

    if (parseFloat(_amount) > 0) {

      _coin = parseFloat(parseFloat(_amount) / parseFloat(_rate)).toFixed(4);
    }
    else if (parseFloat(_coin) > 0) {

      _amount = parseFloat(parseFloat(_coin) * parseFloat(_rate));
    }

    if (parseFloat(_amount) > 0) {

      _currencyamount = parseFloat(parseFloat(_amount) * parseFloat(_currencyrate));
    }

    $('#usdtamount').val(_amount);
    $('#usdtcoin').val(_coin);
    $('#usdtcurrency').val(_currencyamount);
  }

  function InputMandatory(name) {
    var val = $('#' + name + '').val();
");
            WriteLiteral("    if (val == \'\') {\r\n      return false;\r\n    }\r\n    return true;\r\n  }\r\n\r\n  function InputAmountValidate(name) {\r\n    var val = $(\'#\' + name + \'\').val();\r\n    if (parseFloat(val) <= 0) {\r\n      return false;\r\n    }\r\n    return true;\r\n  }\r\n</script>");
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
