#pragma checksum "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Shop\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bdd66d22dc9cf608051fb027653e37025da62bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ShoppingCart), @"mvc.1.0.view", @"/Views/Shop/ShoppingCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/ShoppingCart.cshtml", typeof(AspNetCore.Views_Shop_ShoppingCart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bdd66d22dc9cf608051fb027653e37025da62bc", @"/Views/Shop/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f18393abbd4ce80040ff62ee9bcf8e2b37f5484", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_ClientsCarousel.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Shop\ShoppingCart.cshtml"
  
    ViewData["Title"] = "ShoppingCart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 31, true);
            WriteLiteral("<div class=\"page-title-section\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 128, "\"", 199, 3);
            WriteAttributeValue("", 136, "background-image:url(\'", 136, 22, true);
#line 6 "C:\Users\Google\Desktop\IntillegioМОЙ ВАРИАНТ\Intillegio.Web\Views\Shop\ShoppingCart.cshtml"
WriteAttributeValue("", 158, Url.Content("~/img/abstract-red.jpg"), 158, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 196, "\');", 196, 3, true);
            EndWriteAttribute();
            BeginContext(200, 94, true);
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <h1>Shopping Cart</h1>\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(294, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bdd66d22dc9cf608051fb027653e37025da62bc6252", async() => {
                BeginContext(350, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(358, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(381, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bdd66d22dc9cf608051fb027653e37025da62bc8047", async() => {
                BeginContext(444, 13, true);
                WriteLiteral("Shopping Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(461, 5737, true);
            WriteLiteral(@"</li>
        </ul>
    </div>
</div>
<div class=""section-block"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-sm-8 col-12"">
                <div class=""shop-cart-box"">
                    <div class=""row bx"" id=""1"">
                        <div class=""col-md-1 col-sm-1 col-12 pr-0"">
                            <div class=""button-close"">
                                <a href=""#""><i class=""icon-cancel""></i></a>
                            </div>
                        </div>
                        <div class=""col-md-2 col-sm-2 col-12"">
                            <div class=""shop-cart-box-img"">
                                <img src=""http://via.placeholder.com/95x125"" alt=""img"">
                            </div>
                        </div>
                        <div class=""col-md-4 col-sm-4 col-12"">
                            <div class=""shop-cart-box-info"">
                                <h4>Strategies Book</h4>
               ");
            WriteLiteral(@"                 <span>Bussines Strategies & Advices</span>
                            </div>
                        </div>
                        <div class=""col-md-3 col-sm-3 col-12"">
                            <div class=""shop-cart-box-quantity"">
                                <h6>Quantity</h6>
                                <input class=""form-control form-control-sm"" type=""text"" placeholder=""Quantity"" value=""3"">
                            </div>
                        </div>
                        <div class=""col-md-2 col-sm-2 col-12"">
                            <div class=""shop-cart-box-price"">
                                <h5>$379.00</h5>
                            </div>
                        </div>
                    </div>

                    <div class=""row bx"" id=2>
                        <div class=""col-md-1 col-sm-1 col-12 pr-0"">
                            <div class=""button-close"">
                                <a href=""#""><i class=""icon-cancel""></i></a>");
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-2 col-sm-2 col-12"">
                            <div class=""shop-cart-box-img"">
                                <img src=""http://via.placeholder.com/95x125"" alt=""img"">
                            </div>
                        </div>
                        <div class=""col-md-4 col-sm-4 col-12"">
                            <div class=""shop-cart-box-info"">
                                <h4>Career Growth</h4>
                                <span>Bussines Strategies & Advices</span>
                            </div>
                        </div>
                        <div class=""col-md-3 col-sm-3 col-12"">
                            <div class=""shop-cart-box-quantity"">
                                <h6>Quantity</h6>
                                <input class=""form-control form-control-sm"" type=""text"" placeholder=""Quantity"" value=""1"">
                            </div>
       ");
            WriteLiteral(@"                 </div>
                        <div class=""col-md-2 col-sm-2 col-12"">
                            <div class=""shop-cart-box-price"">
                                <h5>$237.00</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""row bx"" id=""3"">
                        <div class=""col-md-1 col-sm-1 col-12 pr-0"">
                            <div class=""button-close"">
                                <a href=""#""><i class=""icon-cancel""></i></a>
                            </div>
                        </div>
                        <div class=""col-md-2 col-sm-2 col-12"">
                            <div class=""shop-cart-box-img"">
                                <img src=""http://via.placeholder.com/95x125"" alt=""img"">
                            </div>
                        </div>
                        <div class=""col-md-4 col-sm-4 col-12"">
                            <div class=""shop-cart-box-info"">");
            WriteLiteral(@"
                                <h4>Annual Report</h4>
                                <span>Bussines Strategies & Advices</span>
                            </div>
                        </div>
                        <div class=""col-md-3 col-sm-3 col-12"">
                            <div class=""shop-cart-box-quantity"">
                                <h6>Quantity</h6>
                                <input class=""form-control form-control-sm"" type=""text"" placeholder=""Quantity"" value=""1"">
                            </div>
                        </div>
                        <div class=""col-md-2 col-sm-2 col-12"">
                            <div class=""shop-cart-box-price"">
                                <h5>$196.00</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-md-4 col-sm-4 col-12"">
                <div class=""shop-cart-info-price clearfix"">
                   ");
            WriteLiteral(@" <ul class=""right-info-price"">
                        <li>Total Price: <h6>$590.00</h6></li>
                        <li>Shipping Price: <h6>$85.00</h6></li>
                        <li>Tax: <h6>$30.00</h6></li>
                    </ul>
                    <div class=""total-price"">
                        <p>Total: <strong>$705.00</strong></p>
                    </div>
                </div>
                <div class=""mt-25 right-holder"">
                    <a href=""#"" class=""primary-button button-md"">Order Now</a>
                </div>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            BeginContext(6198, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4bdd66d22dc9cf608051fb027653e37025da62bc15870", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
