#pragma checksum "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fded4273626ae855ea8979111d67892877a5f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Details), @"mvc.1.0.view", @"/Views/Articles/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fded4273626ae855ea8979111d67892877a5f0a", @"/Views/Articles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaf799dfc576c31d863c347a72082f848c892f3c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Articles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Księgarnia.Models.Article>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("450"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<strong>");
#nullable restore
#line 8 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8fded4273626ae855ea8979111d67892877a5f0a4837", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
WriteLiteral(Url.Content(Model.FilePath));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div>\r\n    <p>\r\n");
#nullable restore
#line 12 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
         if (Model.CategoryId == 1)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
                                                   
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n    <hr />\r\n    \r\n    <dl class=\"row\">\r\n        \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 40 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
         if (Model.CategoryId == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 43 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 46 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
           Write(Html.DisplayFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 48 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
        } else {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 51 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Producer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 54 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
           Write(Html.DisplayFor(model => model.Producer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 56 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        \r\n    </dl>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Księgarnia.Models.Article> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
