#pragma checksum "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bdb16e0dc46855461d3270124aae28644a49c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Pages_article), @"mvc.1.0.razor-page", @"/Pages/article.cshtml")]
namespace RazorPagesMovie.Pages
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
#line 1 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\_ViewImports.cshtml"
using RazorPagesMovie;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bdb16e0dc46855461d3270124aae28644a49c19", @"/Pages/article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756a50ae9e1ae6c5163d777dbb71451efc16de6f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_article : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
  
    Layout = "Shared/_Layout";
    ViewData["Title"] = "Статья";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main id=\"main\">\r\n\r\n    <div class=\"main-block-article\">\r\n\r\n        <div class=\"article-info\">\r\n            <div class=\"article-headline\">");
#nullable restore
#line 13 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                                     Write(Model.articles.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"article-image\"");
            BeginWriteAttribute("style", " style=\"", 325, "\"", 378, 4);
            WriteAttributeValue("", 333, "background-image:", 333, 17, true);
            WriteAttributeValue(" ", 350, "url(", 351, 5, true);
#nullable restore
#line 14 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
WriteAttributeValue("", 355, Model.articles.Image, 355, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 376, ");", 376, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div class=\"article-info-footer\">\r\n                <div>\r\n                    <div class=\"article-data\">Дата публикации: ");
#nullable restore
#line 17 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                                                          Write(Model.articles.DateCreate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"article-keywordlist\">\r\n");
#nullable restore
#line 19 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                         foreach (var str in @Model.articles.Keywords)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"article-keyword\">");
#nullable restore
#line 21 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                                                    Write(str);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> \r\n");
#nullable restore
#line 22 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                 if (login.IsSession && login.LoginEqualsLoginSession())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bdb16e0dc46855461d3270124aae28644a49c196631", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" style=\"border: 0px; background-color: white\">\r\n                            <div class=\"like-button\">\r\n                                \r\n");
#nullable restore
#line 31 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                                 if (Model.IsSelected)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <svg class=""active"" id=""like"" fill=""var(--white-color)"" viewBox=""-10 -20 552 552"" xmlns=""http://www.w3.org/2000/svg""><path d=""m471.382812 44.578125c-26.503906-28.746094-62.871093-44.578125-102.410156-44.578125-29.554687 0-56.621094 9.34375-80.449218 27.769531-12.023438 9.300781-22.917969 20.679688-32.523438 33.960938-9.601562-13.277344-20.5-24.660157-32.527344-33.960938-23.824218-18.425781-50.890625-27.769531-80.445312-27.769531-39.539063 0-75.910156 15.832031-102.414063 44.578125-26.1875 28.410156-40.613281 67.222656-40.613281 109.292969 0 43.300781 16.136719 82.9375 50.78125 124.742187 30.992188 37.394531 75.535156 75.355469 127.117188 119.3125 17.613281 15.011719 37.578124 32.027344 58.308593 50.152344 5.476563 4.796875 12.503907 7.4375 19.792969 7.4375 7.285156 0 14.316406-2.640625 19.785156-7.429687 20.730469-18.128907 40.707032-35.152344 58.328125-50.171876 51.574219-43.949218 96.117188-81.90625 127.109375-119.304687 34.644532-41.800781 50.777344-81.4375 50.777344-124");
                WriteLiteral(".742187 0-42.066407-14.425781-80.878907-40.617188-109.289063zm0 0\"/></svg>\r\n");
#nullable restore
#line 34 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <svg id=""like"" fill=""var(--white-color)"" viewBox=""-10 -20 552 552"" xmlns=""http://www.w3.org/2000/svg""><path d=""m471.382812 44.578125c-26.503906-28.746094-62.871093-44.578125-102.410156-44.578125-29.554687 0-56.621094 9.34375-80.449218 27.769531-12.023438 9.300781-22.917969 20.679688-32.523438 33.960938-9.601562-13.277344-20.5-24.660157-32.527344-33.960938-23.824218-18.425781-50.890625-27.769531-80.445312-27.769531-39.539063 0-75.910156 15.832031-102.414063 44.578125-26.1875 28.410156-40.613281 67.222656-40.613281 109.292969 0 43.300781 16.136719 82.9375 50.78125 124.742187 30.992188 37.394531 75.535156 75.355469 127.117188 119.3125 17.613281 15.011719 37.578124 32.027344 58.308593 50.152344 5.476563 4.796875 12.503907 7.4375 19.792969 7.4375 7.285156 0 14.316406-2.640625 19.785156-7.429687 20.730469-18.128907 40.707032-35.152344 58.328125-50.171876 51.574219-43.949218 96.117188-81.90625 127.109375-119.304687 34.644532-41.800781 50.777344-81.4375 50.777344-124.742187 0-42.06");
                WriteLiteral("6407-14.425781-80.878907-40.617188-109.289063zm0 0\"/></svg>\r\n");
#nullable restore
#line 38 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    \r\n                            </div>\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div class=\"article-text\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\article.cshtml"
       Write(Model.articles.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n</main>\r\n\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <script src=\"/js/like-button.js\"></script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Footer", async() => {
                WriteLiteral("\r\n    <script src=\"/js/back-to-top.js\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.article> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.article> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.article>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.article Model => ViewData.Model;
    }
}
#pragma warning restore 1591
