#pragma checksum "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\SuccessFormPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2980d020f821c08196441d40f52389604a9a605f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HO_SuccessFormPost), @"mvc.1.0.view", @"/Views/HO/SuccessFormPost.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2980d020f821c08196441d40f52389604a9a605f", @"/Views/HO/SuccessFormPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3219487375709b78cdc3d07587f985a228390908", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HO_SuccessFormPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\SuccessFormPost.cshtml"
  
    Layout = "~/Views/Shared/_HOLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""dss-right-section noside-right-full"">
    <div class=""dashboard-center"">
        <div class=""custom-breadcrumb"">
            <ol class=""cd-breadcrumb"">
                <li><a href=""#"">Dashboard</a></li>
                <li><a href=""#0"">Success</a></li>
            </ol>
        </div>
        <div class=""dashboard-center-itm"">
            <div class=""success-page shadow-custom"">

                <div class=""success-page-inner"">
                    <div class=""success-check""></div>
                    <div class=""success-title"">Success!</div>
                    <div class=""success-content"">
");
#nullable restore
#line 20 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\SuccessFormPost.cshtml"
                          
                            if (ViewData["_SuccessMessage"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>");
#nullable restore
#line 23 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\SuccessFormPost.cshtml"
                                  Write(ViewData["_SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 24 "D:\codetrx-Laptop\CodeTrex\Projects\ture-click\webcode\webcode\Views\HO\SuccessFormPost.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n</div>");
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
