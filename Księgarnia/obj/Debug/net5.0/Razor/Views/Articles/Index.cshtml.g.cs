#pragma checksum "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f48a2336fc1073a552735d7078a30765eb953b84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Index), @"mvc.1.0.view", @"/Views/Articles/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f48a2336fc1073a552735d7078a30765eb953b84", @"/Views/Articles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaf799dfc576c31d863c347a72082f848c892f3c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Articles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Księgarnia.Models.Article>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p");
            BeginWriteAttribute("style", " style=\"", 92, "\"", 156, 3);
            WriteAttributeValue("", 100, "font-size:20px;color:", 100, 21, true);
#nullable restore
#line 6 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
WriteAttributeValue(" ", 121, ViewData["col"], 122, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 138, ";text-align:center", 138, 18, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 7 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
Write(ViewData["fav"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p style=\"font-size:20px;color: red;text-align:center\">\r\n    ");
#nullable restore
#line 10 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
Write(ViewData["b"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
 if(ViewBag.koszykInfo == 1) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 style=\"font-size:20px;color:green;text-align:center\">Added to cart</h4>\r\n");
#nullable restore
#line 15 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f48a2336fc1073a552735d7078a30765eb953b848572", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<div class=""container-fluid px-0"">
    <nav class=""navbar navbar-expand-lg navbar-light bg-light navbar-fixed"">
        <div class=""container-fluid d-flex""> <a class=""navbar-brand"" href=""#"">Choose category</a>
            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                <li class=""nav-item"" role=""presentation""> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f48a2336fc1073a552735d7078a30765eb953b8410092", async() => {
                WriteLiteral("All");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </li>\r\n                <li class=\"nav-item\" role=\"presentation\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f48a2336fc1073a552735d7078a30765eb953b8411602", async() => {
                WriteLiteral("Products");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </li>\r\n                <li class=\"nav-item\" role=\"presentation\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f48a2336fc1073a552735d7078a30765eb953b8413627", async() => {
                WriteLiteral("Books");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </li>
            </ul>
        </div>
    </nav>
</div>
<div class=""container-fluid mt-2 mb-5"">
    <div class=""products"">
        <div class=""tab-content"" id=""myTabContent"">

            <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                <div class=""row g-3"">
");
#nullable restore
#line 36 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                            <div class=\"card\">\r\n                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f48a2336fc1073a552735d7078a30765eb953b8416349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
                               WriteLiteral(Url.Content(item.FilePath));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                    <div class=\"d-flex justify-content-between\"> <span class=\"font-weight-bold\"> ");
#nullable restore
#line 42 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
                                                                                                            Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </div>\r\n                                \r\n                                    <div class=\"d-flex align-items-center flex-row\">  <span class=\"guarantee\">  ");
#nullable restore
#line 44 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
                                                                                                           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </span> </div>\r\n                                    <div class=\"d-flex justify-content-between\"> <span class=\"font-weight-bold\">");
#nullable restore
#line 45 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
                                                                                                           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span> </div>

                            </div>
                            <hr>
                            <div class=""card-body"">
                                    <div>
                                        <input type=""button"" class=""btn btn-outline-dark"" value=""Details"" name=""back""");
            BeginWriteAttribute("onclick", "\r\n                                     onclick=\"", 2696, "\"", 2901, 1);
#nullable restore
#line 52 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
WriteAttributeValue("", 2744, "location.href='" 
                                   + Url.Action("Details", "Articles", new { id = item.Id })
                                   + "'", 2744, 157, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <input type=\"button\" class=\"btn btn-outline-dark\" value=\"Favourites\" name=\"back\"");
            BeginWriteAttribute("onclick", "\r\n                                           onclick=\"", 3023, "\"", 3244, 1);
#nullable restore
#line 56 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
WriteAttributeValue("", 3077, "location.href='"
                                   + Url.Action("AddToFavourite", "Favourities",  new { id = item.Id })
                                   + "'", 3077, 167, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <input type=\"button\" class=\"btn btn-outline-dark\" value=\"Add to cart\" name=\"back\"");
            BeginWriteAttribute("onclick", "\r\n                                           onclick=\"", 3367, "\"", 3579, 1);
#nullable restore
#line 60 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
WriteAttributeValue("", 3421, "location.href='"
                                   + Url.Action("BuyArticle", "CartItems", new {id = item.Id})
                                   + "'", 3421, 158, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 67 "C:\Users\ms200\Projektowanie-oprogramowania\Projektowanie-oprogramowania\Księgarnia\Views\Articles\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Księgarnia.Models.Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
