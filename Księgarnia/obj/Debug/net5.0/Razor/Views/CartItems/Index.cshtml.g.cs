#pragma checksum "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db966c86f39a87e2ee46e2d9b027f4f5c23a1f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CartItems_Index), @"mvc.1.0.view", @"/Views/CartItems/Index.cshtml")]
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
#line 1 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\_ViewImports.cshtml"
using Księgarnia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\_ViewImports.cshtml"
using Księgarnia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db966c86f39a87e2ee46e2d9b027f4f5c23a1f5", @"/Views/CartItems/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaf799dfc576c31d863c347a72082f848c892f3c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CartItems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Księgarnia.Models.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
  
    double total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3><center>Shopping cart</center></h3>\r\n\r\n<p style=\"font-size:30px\" class=\"info\">\r\n    ");
#nullable restore
#line 12 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"font-size:30px\" class=\"warning\">\r\n        Your cart is empty!\r\n    </p>\r\n");
#nullable restore
#line 20 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n            \r\n                ");
#nullable restore
#line 32 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Article.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\r\n                ");
#nullable restore
#line 33 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Article.Producer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n            </th>\r\n            \r\n\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5db966c86f39a87e2ee46e2d9b027f4f5c23a1f57548", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
                      WriteLiteral(Url.Content(item.Article.FilePath));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Article.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Article.Producer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    \r\n                    \r\n                    \r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
                          
                            total = total + item.TotalPrice;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 77 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 85 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
  
    total = Math.Round(total, 4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"start\">Total ");
#nullable restore
#line 89 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
                   Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div>\r\n    <input type=\"button\" class=\"btn btn-outline-dark\" value=\"Edit\" name=\"back\"");
            BeginWriteAttribute("onclick", "\r\n           onclick=\"", 2318, "\"", 2474, 1);
#nullable restore
#line 93 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
WriteAttributeValue("", 2340, "location.href='"
                                   + Url.Action("Index2", "CartItems")
                                   + "'", 2340, 134, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"button\" class=\"btn btn-outline-dark\" value=\"Order\" name=\"back\"");
            BeginWriteAttribute("onclick", "\r\n           onclick=\"", 2559, "\"", 2725, 1);
#nullable restore
#line 97 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\CartItems\Index.cshtml"
WriteAttributeValue("", 2581, "location.href='"
                                   + Url.Action("AddToFavourite", "Favourities")
                                   + "'", 2581, 144, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Księgarnia.Models.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
