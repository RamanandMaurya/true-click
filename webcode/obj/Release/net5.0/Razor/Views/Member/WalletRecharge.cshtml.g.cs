#pragma checksum "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94ede053ccb1b3475f317345da51cfabc6f06fbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_WalletRecharge), @"mvc.1.0.view", @"/Views/Member/WalletRecharge.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94ede053ccb1b3475f317345da51cfabc6f06fbb", @"/Views/Member/WalletRecharge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_WalletRecharge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
  
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
                <li><a href=""#0"">Add Fund</a></li>
            </ol>
        </div>
        
        <div class=""dashboard-center-itm"">
            <div class=""prasonal-dd shadow-custom"">
");
#nullable restore
#line 17 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
                 using (Html.BeginForm("WalletRecharge", "Member", FormMethod.Post, new { enctype = "multipart/form-data" }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""prasonal-form"">
                    <div class=""pre-title-ue"">Add Fund</div>
                    <div class=""fundFormWrap"">
                      <div class=""fundType"">
                        <div class=""fundDesign dhanuFund""><img src=""/assets_backend/images/dhanu1.png"" alt=""logo""> Dhanu (Crypto Deposit)</div>
                      </div>
                      <div class=""formWithQR"">
                        <div class=""mainQRCode"">
                          <div class=""qrAddressMain"">
                            <span>DHANU Deposit Address</span>
                          </div>
                          <div class=""QRInner"">
                            <img src=""/assets_backend/images/dhanuQR.png"" alt=""QR Code"">
                          </div>
                          <div class=""QRInnerDetail"">
                            <div class=""QRInnerDetailIn"">
                              <input value=""0xefc91aaaff99c44d78391b48c0c9d8e751171e3d"" id=""dhanu_QRClipboard""");
            WriteLiteral(@">
                              <h5 onclick=""dhanucopyQR()"">0xefc91aaaff99c44d78391b48c0c9d8e751171e3d <span><i class='fa fa-copy'></i></span></h5>
                              <div id=""dhanucopiedsuccess"" class=""qr_copied"">
                                <span>Copied!</span>
                              </div>
                            </div>
                          </div>
                        </div>
                        <div class=""form-main no-flex"">
                          <div id=""divDhanu"" class=""login-intup col-ff-maxL"">
");
            WriteLiteral(@"                            <div class=""all-lbl-inp threeInp"">
                              <div class=""single-row-inp"">
                                <span>Amount ($)</span>
                                <input type=""text"" name=""dhanuamount"" id=""dhanuamount""");
            BeginWriteAttribute("value", " value=\"", 2540, "\"", 2548, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter amount"" class=""login-inp"" autocomplete=""off"">
                              </div>
                              <div class=""single-row-inp"">
                                <span>Coins</span>
                                <input type=""number"" name=""dhanucoin"" id=""dhanucoin"" value=""0"" class=""login-inp color-yellow"" disabled>
                              </div>
                              <div class=""single-row-inp"">
                                <span>Amount <label>(<img src=""/assets_backend/images/rupees.png"" alt=""logo"">)</label></span>
                                <input type=""number"" name=""dhanucurrency"" id=""dhanucurrency"" value=""0"" class=""login-inp color-red"" disabled>
                              </div>
                            </div>
                          </div>
                          <div id=""divTotal"" class=""login-intup col-ff-maxL"" style=""display:none;"">
                            <div class=""all-lbl"">TOTAL </div>
                            <di");
            WriteLiteral(@"v class=""all-lbl-inp threeInp"">
                              <div class=""single-row-inp"">
                                <span>Amount ($)</span>
                                <input type=""number"" name=""amount"" id=""amount"" value=""0"" class=""login-inp"" disabled>
                              </div>
                              <div class=""single-row-inp"">
                                <span>Coins</span>
                                <input type=""number"" name=""amount"" id=""amount"" value=""0"" class=""login-inp color-yellow"" disabled>
                              </div>
                              <div class=""single-row-inp"">
                                <span>Amount ($)</span>
                                <input type=""number"" name=""amount"" id=""amount"" value=""0"" class=""login-inp color-red"" disabled>
                              </div>
                            </div>
                          </div>
                          <div class=""login-intup col-ff-maxL"">
                   ");
            WriteLiteral(@"         <div class=""all-lbl"">Payment Receipt</div>
                            <input type=""file"" name=""fileDhanu"" class=""login-inp"">
                          </div>
                          <div class=""login-intup col-ff-maxL"" style=""display:none"">
                            <div class=""all-lbl"">Remark</div>
                            <textarea class=""login-inp text-area"" id=""remark"" name=""remark""></textarea>
                          </div>
                          <div class=""submit-btn-wrap text-align-left"" style=""display:none"">
");
#nullable restore
#line 87 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
                              
                              string err1 = "";
                              if (ViewData["_ErrorMessage"] != null)
                              {
                                err1 = ViewData["_ErrorMessage"].ToString();
                              }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label id=\"lblerrDhanu\" style=\"color:#cb0f0f\">");
#nullable restore
#line 94 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
                                                                     Write(err1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label><br />
                            <button type=""submit"" class=""admin-btn"" id=""btnDhanu"" name=""submit"" value=""DHANU"">Submit Request</button>
                          </div>
                        </div>
                      </div>

                      <div class=""fundType mt-adds"">
                        <div class=""fundDesign usdtFund""><img src=""/assets_backend/images/usdt.png"" alt=""logo""> USDT (Crypto Deposit)</div>
                      </div>

                      <div class=""formWithQR"">
                        <div class=""mainQRCode"">
                          <div class=""qrAddressMain"">
                            <span>USDT Deposit Address</span>
                          </div>
                          <div class=""QRInner"">
                            <img src=""/assets_backend/images/usdtQR.png"" alt=""QR Code"">
                          </div>
                          <div class=""QRInnerDetail"">
                            <div class=""QRInnerDetailIn"">
            ");
            WriteLiteral(@"                  <input value=""0x4ede3facfd6d7473346139135918099bc01d82d7"" id=""usdt_QRClipboard"">
                              <h5 onclick=""usdtcopyQR()"">0x4ede3facfd6d7473346139135918099bc01d82d7 <span><i class='fa fa-copy'></i></span></h5>
                              <div id=""usdt-copied-success"" class=""qr_copied"">
                                <span>Copied!</span>
                              </div>
                            </div>
                          </div>
                        </div>
                        <div class=""form-main no-flex"">
                          <div id=""divUsdt"" class=""login-intup col-ff-maxL"">
");
            WriteLiteral(@"                            <div class=""all-lbl-inp threeInp"">
                              <div class=""single-row-inp"">
                                <span>Amount ($)</span>
                                <input type=""text"" name=""usdtamount"" id=""usdtamount""");
            BeginWriteAttribute("value", " value=\"", 7565, "\"", 7573, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter amount"" class=""login-inp"" autocomplete=""off"">
                              </div>
                              <div class=""single-row-inp"">
                                <span>Coins</span>
                                <input type=""number"" name=""usdtcoin"" id=""usdtcoin"" value=""0"" class=""login-inp color-yellow"" disabled>
                              </div>
                              <div class=""single-row-inp"">
                                <span>Amount <label>(<img src=""/assets_backend/images/rupees.png"" alt=""logo"">)</label></span>
                                <input type=""number"" name=""usdtcurrency"" id=""usdtcurrency"" value=""0"" class=""login-inp color-red"" disabled>
                              </div>
                            </div>
                          </div>

                          <div class=""login-intup col-ff-maxL"">
                            <div class=""all-lbl"">Payment Receipt</div>
                            <input type=""file"" name=""fileUsd");
            WriteLiteral(@"t"" class=""login-inp"">
                          </div>
                        </div>
                      </div>

                      <div class=""fundType mt-adds"">
                        <div class=""fundDesign usdtFund""><img src=""/assets_backend/images/usdt.png"" alt=""logo""> USDT (Trading Pool)</div>
                      </div>

                      <div class=""formWithQR"">
                        <div class=""mainQRCode"">
                          <div class=""qrAddressMain"">
                            <span>USDT Deposit Address</span>
                          </div>
                          <div class=""QRInner"">
                            <img src=""/assets_backend/images/usdtQR.png"" alt=""QR Code"">
                          </div>
                          <div class=""QRInnerDetail"">
                            <div class=""QRInnerDetailIn"">
                              <input value=""0x4ede3facfd6d7473346139135918099bc01d82d7"" id=""usdt_QRClipboard"">
                              ");
            WriteLiteral(@"<h5 onclick=""usdtcopyQR()"">0x4ede3facfd6d7473346139135918099bc01d82d7 <span><i class='fa fa-copy'></i></span></h5>
                              <div id=""usdt-copied-success"" class=""qr_copied"">
                                <span>Copied!</span>
                              </div>
                            </div>
                          </div>
                        </div>
                        <div class=""form-main no-flex"">
                          <div id=""divUsdt"" class=""login-intup col-ff-maxL"">
");
            WriteLiteral(@"                            <div class=""all-lbl-inp threeInp"">
                              <div class=""single-row-inp"">
                                <span>Amount ($)</span>
                                <input type=""text"" name=""tpusdtamount"" id=""tpusdtamount""");
            BeginWriteAttribute("value", " value=\"", 10482, "\"", 10490, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter amount"" class=""login-inp"" autocomplete=""off"">
                              </div>
                              <div class=""single-row-inp"">
                                <span>Coins</span>
                                <input type=""number"" name=""tpusdtcoin"" id=""tpusdtcoin"" value=""0"" class=""login-inp color-yellow"" disabled>
                              </div>
                              <div class=""single-row-inp"">
                                <span>Amount <label>(<img src=""/assets_backend/images/rupees.png"" alt=""logo"">)</label></span>
                                <input type=""number"" name=""tpusdtcurrency"" id=""tpusdtcurrency"" value=""0"" class=""login-inp color-red"" disabled>
                              </div>
                            </div>
                          </div>

                          <div class=""login-intup col-ff-maxL"">
                            <div class=""all-lbl"">Payment Receipt</div>
                            <input type=""file"" name=");
            WriteLiteral(@"""filetpUsdt"" class=""login-inp"">
                          </div>
                          <div class=""login-intup col-ff-maxL"">
                            <div class=""all-lbl"">Remark</div>
                            <textarea class=""login-inp text-area"" id=""remark"" name=""remark""></textarea>
                          </div>
                          <div class=""submit-btn-wrap text-align-left"">
");
#nullable restore
#line 198 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
                              
                              string err2 = "";
                              if (ViewData["_ErrorMessage"] != null)
                              {
                                err2 = ViewData["_ErrorMessage"].ToString();
                              }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label id=\"lblerrUsdt\" style=\"color:#cb0f0f\">");
#nullable restore
#line 205 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
                                                                    Write(err2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label><br />
                            <button type=""submit"" class=""admin-btn"" id=""btnUsdt"" name=""submit"" value=""USDT"">Submit Request</button>
                          </div>
                        </div>
                      </div>
                    </div>


                    <div class=""submit-btn-wrap text-align-left"">

");
            WriteLiteral("<br />\r\n");
            WriteLiteral("                      <input type=\"hidden\" name=\"dhanurate\" id=\"dhanurate\"");
            BeginWriteAttribute("value", " value=\"", 12953, "\"", 12988, 1);
#nullable restore
#line 217 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
WriteAttributeValue("", 12961, ViewData["_dhanucoinrate"], 12961, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                      <input type=\"hidden\" name=\"usdtrate\" id=\"usdtrate\"");
            BeginWriteAttribute("value", " value=\"", 13064, "\"", 13098, 1);
#nullable restore
#line 218 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
WriteAttributeValue("", 13072, ViewData["_usdtcoinrate"], 13072, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                      <input type=\"hidden\" name=\"tpusdtrate\" id=\"tpusdtrate\"");
            BeginWriteAttribute("value", " value=\"", 13178, "\"", 13214, 1);
#nullable restore
#line 219 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
WriteAttributeValue("", 13186, ViewData["_tpusdtcoinrate"], 13186, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                      <input type=\"hidden\" name=\"currencyrate\" id=\"currencyrate\"");
            BeginWriteAttribute("value", " value=\"", 13298, "\"", 13332, 1);
#nullable restore
#line 220 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
WriteAttributeValue("", 13306, ViewData["_currencyrate"], 13306, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 223 "C:\old pc\Codetrex\Codetrex\BAAP\Application Code\WEB Code\webcode\webcode\Views\Member\WalletRecharge.cshtml"
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

        $('#dhanuamount').on('change', function () {

            if (!InputMandatory(""dhanuamount"")) {
                $('#dhanuamount').val('0');
                $('#dhanucoin').val('0');
            }

            if (!InputAmountValidate(""dhanuamount"")) {
                $('#dhanuamount').val('0');
                $('#dhanucoin').val('0');
            }

            DhanuCalc();
            return false;
        });

        $('#dhanucoin').on('change', function () {

            if (!InputMandatory(""dhanucoin"")) {
                $('#dhanucoin').val('0');
            }

            if (!InputAmountValidate(""dhanucoin"")) {
                $('#dhanucoin').val('0');
            }

            DhanuCalc();
            return false;
        });


        $('#usdtamount').on('change', function () {

            if (!InputMandatory(""usdtamount"")) {
                $(");
            WriteLiteral(@"'#usdtamount').val('0');
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
            }

            if (!InputAmountValidate(""usdtcoin"")) {
                $('#usdtcoin').val('0');
                alert('Please enter valid recharge amount. !!');
            }

            UsdtCalc();
            return false;
        });

      $('#tpusdtamount').on('change', function () {

        if (!InputMandatory(""tpusdtamount"")) {
          $('#tpusdtamount').val('0');
          $('#tpusdtcoin').val('0');
        }

        if (!InputAmountValidate(""tpusdtamount"")) {
          $('#tpusdtamount').val('0');
          $('#tpusdtco");
            WriteLiteral(@"in').val('0');
        }

        tpUsdtCalc();
        return false;
      });

      $('#tpusdtcoin').on('change', function () {

        if (!InputMandatory(""tpusdtcoin"")) {
          $('#tpusdtcoin').val('0');
        }

        if (!InputAmountValidate(""tpusdtcoin"")) {
          $('#tpusdtcoin').val('0');
          alert('Please enter valid recharge amount. !!');
        }

        tpUsdtCalc();
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

    function DhanuCalc() {

        var _rate = $('#dhanurate').val();
        var _amount = $('#dhanuamount').val();
        var _coin = $('#dhanucoin').val();
        var _currencyrate = $('#currencyrate').val();
        var _currencyam");
            WriteLiteral(@"ount = 0;

        if (_amount == '') {
            _amount = 0;
        }

        if (_coin == '') {
            _coin = 0;
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

        $('#dhanuamount').val(_amount);
        $('#dhanucoin').val(_coin);
        $('#dhanucurrency').val(_currencyamount);
    }

    function UsdtCalc() {

        var _rate = $('#usdtrate').val();
        var _amount = $('#usdtamount').val();
        var _coin = $('#usdtcoin').val();
        var _currencyrate = $('#currencyrate').val();
        var _currencyamount = 0;

        if (_amount == '') {
            _amount = 0;
        }

");
            WriteLiteral(@"        if (_coin == '') {
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

  function tpUsdtCalc() {

    var _rate = $('#tpusdtrate').val();
    var _amount = $('#tpusdtamount').val();
    var _coin = $('#tpusdtcoin').val();
    var _currencyrate = $('#currencyrate').val();
    var _currencyamount = 0;

    if (_amount == '') {
      _amount = 0;
    }

    if (_coin == '') {
      _coi");
            WriteLiteral(@"n = 0;
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

    $('#tpusdtamount').val(_amount);
    $('#tpusdtcoin').val(_coin);
    $('#tpusdtcurrency').val(_currencyamount);
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
        if (!SelectMandatory(""wallettype"")) {
            error = 'Ple");
            WriteLiteral(@"ase choose wallet type. !!';
            return error;
        }

        if (!InputMandatory(""amount"")) {
            error = 'Please enter recharge amount. !!';
            return error;
        }

        if (!InputAmountValidate(""amount"")) {
            error = 'Please enter valid recharge amount. !!';
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
