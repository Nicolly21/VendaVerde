#pragma checksum "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f15b52f252ceb48bebb2cfbce928f53db42b41d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
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
#line 1 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\_ViewImports.cshtml"
using VendaVerde;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\_ViewImports.cshtml"
using VendaVerde.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\_ViewImports.cshtml"
using VendaVerde.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f15b52f252ceb48bebb2cfbce928f53db42b41d", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ea3ff383141c19eb50721c788104a4d5003c37d", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-wrap hero-bread"" style=""background-image: url('/images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Carrinho</span></p>
                <h1 class=""mb-0 bread"">Meu carrinho</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section ftco-cart"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 ftco-animate"">
                <div class=""cart-list"">
                    <table class=""table"">
                        <thead class=""thead-primary"">
                            <tr class=""text-center"">
                                <th>&nbsp;</th>
                                <th>Nome do produto</th>
                                <th>Pre??o</th>
                   ");
            WriteLiteral("             <th>Quantidade</th>\r\n                                <th>Subtotal</th>\r\n                            </tr>\r\n                        </thead>\r\n");
#nullable restore
#line 29 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\Carrinho\Index.cshtml"
                         foreach (var item in Model.Carrinho.ItensCarrinho)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tbody>\r\n                                <tr class=\"text-center\">\r\n                                    <td class=\"product-remove\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f15b52f252ceb48bebb2cfbce928f53db42b41d6625", async() => {
                WriteLiteral("<span class=\"ion-ios-close\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-produtoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\Carrinho\Index.cshtml"
                                                                                                                                         WriteLiteral(item.ItemCarrinhoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["produtoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-produtoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["produtoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    <td class=\"product-name\">\r\n                                        <h3>");
#nullable restore
#line 35 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\Carrinho\Index.cshtml"
                                       Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </td>\r\n\r\n                                    <td class=\"price\">");
#nullable restore
#line 38 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\Carrinho\Index.cshtml"
                                                 Write(item.Produto.Preco.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td class=\"quantity\">\r\n");
            WriteLiteral("                                        ");
#nullable restore
#line 44 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\Carrinho\Index.cshtml"
                                   Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td class=\"total\">");
#nullable restore
#line 47 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\Carrinho\Index.cshtml"
                                                  Write((item.Quantidade * item.Produto.Preco).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr><!-- END TR-->\r\n                            </tbody>\r\n");
#nullable restore
#line 50 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\Carrinho\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                </div>
            </div>
        </div>
        <div class=""row justify-content-end"">
            
            <div class=""col-lg-4 mt-5 cart-wrap ftco-animate"">
                <div class=""cart-total mb-3"">
                    <h3>Estimate shipping and tax</h3>
                    <p>Enter your destination to get a shipping estimate</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f15b52f252ceb48bebb2cfbce928f53db42b41d11538", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 3097, "\"", 3103, 0);
                EndWriteAttribute();
                WriteLiteral(">Country</label>\r\n                            <input type=\"text\" class=\"form-control text-left px-3\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3204, "\"", 3218, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"country\">State/Province</label>\r\n                            <input type=\"text\" class=\"form-control text-left px-3\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3459, "\"", 3473, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"country\">Zip/Postal Code</label>\r\n                            <input type=\"text\" class=\"form-control text-left px-3\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3715, "\"", 3729, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <p><a href=""checkout.html"" class=""btn btn-primary py-3 px-4"">Estimate</a></p>
            </div>

            <div class=""col-lg-4 mt-5 cart-wrap ftco-animate"">
                <div class=""cart-total mb-3"">
                    <h3>Total da compra</h3>
                    <hr>
                    <p class=""d-flex total-price"">
                        <span>Total</span>
                        <span>");
#nullable restore
#line 85 "C:\Users\n.de.oliveira.santos\Desktop\V\VendaVerde\VendaVerde\Views\Carrinho\Index.cshtml"
                         Write(Model.TotalItensCarrinho.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </p>\r\n                </div>\r\n                <p><a href=\"checkout.html\" class=\"btn btn-primary py-3 px-4\">Confirmar Compra</a></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
