#pragma checksum "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Projects\PartialViews\_ProjectsSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6951ec32b3552dd072799946bab75f40839fb2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_PartialViews__ProjectsSection), @"mvc.1.0.view", @"/Views/Projects/PartialViews/_ProjectsSection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/PartialViews/_ProjectsSection.cshtml", typeof(AspNetCore.Views_Projects_PartialViews__ProjectsSection))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6951ec32b3552dd072799946bab75f40839fb2c", @"/Views/Projects/PartialViews/_ProjectsSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f18393abbd4ce80040ff62ee9bcf8e2b37f5484", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_PartialViews__ProjectsSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Intillegio.Common.ViewModels.LastProjectsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 243, true);
            WriteLiteral("<div class=\"section-block\">\r\n    <div class=\"container\">\r\n        <div class=\"section-heading\">\r\n            <h4>Latest Projects</h4>\r\n            <div class=\"section-heading-line-left\"></div>\r\n        </div>\r\n        <div class=\"row mt-30\">\r\n");
            EndContext();
#line 9 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Projects\PartialViews\_ProjectsSection.cshtml"
             foreach (var project in Model)
            {

#line default
#line hidden
            BeginContext(368, 192, true);
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-12\">\r\n                    <div class=\"project-grid\">\r\n                        <div class=\"project-grid-img\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 560, "\"", 580, 1);
#line 14 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Projects\PartialViews\_ProjectsSection.cshtml"
WriteAttributeValue("", 566, project.Image, 566, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(581, 149, true);
            WriteLiteral(" alt=\"img\">\r\n                        </div>\r\n                        <div class=\"project-grid-overlay\">\r\n                            <h4><a href=\"#\">");
            EndContext();
            BeginContext(731, 12, false);
#line 17 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Projects\PartialViews\_ProjectsSection.cshtml"
                                       Write(project.Name);

#line default
#line hidden
            EndContext();
            BeginContext(743, 42, true);
            WriteLiteral("</a></h4>\r\n                            <p>");
            EndContext();
            BeginContext(786, 16, false);
#line 18 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Projects\PartialViews\_ProjectsSection.cshtml"
                          Write(project.Category);

#line default
#line hidden
            EndContext();
            BeginContext(802, 40, true);
            WriteLiteral("</p>\r\n                            <span>");
            EndContext();
            BeginContext(843, 13, false);
#line 19 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Projects\PartialViews\_ProjectsSection.cshtml"
                             Write(project.Stage);

#line default
#line hidden
            EndContext();
            BeginContext(856, 93, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 23 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Projects\PartialViews\_ProjectsSection.cshtml"
            }

#line default
#line hidden
            BeginContext(964, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Intillegio.Common.ViewModels.LastProjectsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
