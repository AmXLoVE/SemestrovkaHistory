#pragma checksum "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15120bb94fe31f6758fe17cbd603adfcac451aa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Pages_forum), @"mvc.1.0.razor-page", @"/Pages/forum.cshtml")]
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
#line 1 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\_ViewImports.cshtml"
using RazorPagesMovie;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15120bb94fe31f6758fe17cbd603adfcac451aa5", @"/Pages/forum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756a50ae9e1ae6c5163d777dbb71451efc16de6f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_forum : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
  
    Layout = "Shared/_Layout";
    ViewData["Title"] = "Форум";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main id=\"main\">\r\n    <div class=\"main-block-forum\">\r\n");
#nullable restore
#line 11 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
         if (login.IsSession && login.LoginEqualsLoginSession())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"forum-header\">\r\n                <div class=\"forum-headline\">Обсуждения</div>\r\n                <div><a href=\"/new-discussion\"><button class=\"add-discussion\">Создать</button></a></div>\r\n            </div>\r\n");
#nullable restore
#line 17 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"login-message\">\r\n                <div>Вы не можете создавать обсуждения, пока не выполните <a href=\"/login\">вход</a></div>\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"forum-discussions\">\r\n");
#nullable restore
#line 26 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
             foreach (var e in Model._list)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 815, "\"", 854, 2);
            WriteAttributeValue("", 822, "/discussion?open=", 822, 17, true);
#nullable restore
#line 28 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
WriteAttributeValue("", 839, e.DiscussionId, 839, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"forum-discussion-item\">\r\n                    <div class=\"forum-discussion-container\">\r\n                        <div class=\"forum-discussion-headline\">");
#nullable restore
#line 30 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
                                                          Write(e.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"forum-discussion-text\">\r\n                            ");
#nullable restore
#line 32 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
                       Write(e.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-discussion-info\">");
#nullable restore
#line 34 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
                                                     Write(e.PersonCreateLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 34 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
                                                                           Write(e.TimeCreate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 37 "C:\KIRILL\Programming\GIT\semwork 3 sem 2 course\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\forum.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</main>\r\n\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.forum> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.forum> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.forum>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.forum Model => ViewData.Model;
    }
}
#pragma warning restore 1591
