#pragma checksum "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Home\PartialViews\Index\_MainImageSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b6dd0cd68f9ad9f30c5242c4f8ee1864cf3fef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PartialViews_Index__MainImageSection), @"mvc.1.0.view", @"/Views/Home/PartialViews/Index/_MainImageSection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PartialViews/Index/_MainImageSection.cshtml", typeof(AspNetCore.Views_Home_PartialViews_Index__MainImageSection))]
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
#line 1 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\_ViewImports.cshtml"
using Intillegio.Web;

#line default
#line hidden
#line 2 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\_ViewImports.cshtml"
using Intillegio.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b6dd0cd68f9ad9f30c5242c4f8ee1864cf3fef6", @"/Views/Home/PartialViews/Index/_MainImageSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f18393abbd4ce80040ff62ee9bcf8e2b37f5484", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PartialViews_Index__MainImageSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 31, true);
            WriteLiteral("<div class=\"main-image-section\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 31, "\"", 97, 3);
            WriteAttributeValue("", 39, "background-image:url(\'", 39, 22, true);
#line 1 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Home\PartialViews\Index\_MainImageSection.cshtml"
WriteAttributeValue("", 61, Url.Content("~/img/MainImg.jpg"), 61, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 94, "\');", 94, 3, true);
            EndWriteAttribute();
            BeginContext(98, 1094, true);
            WriteLiteral(@">
    <!-- Overlay Start -->
    <div class=""medium-overlay""></div>
    <!-- Overlay End -->

    <div class=""main-image-content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-12 col-12 offset-md-3"">
                    <div class=""center-holder"">
                        <h2>
                            We will help to improve your business
                        </h2>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                            tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                            quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo.
                        </p>
                        <div class=""mt-30"">
                            <a href=""#contact"" class=""primary-button button-md"">Lean More</a>
                        </div>
                    </div>
        ");
            WriteLiteral("        </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
