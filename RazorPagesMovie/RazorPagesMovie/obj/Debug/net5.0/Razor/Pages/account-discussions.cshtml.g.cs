#pragma checksum "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd5d17e87fc587ad70c49f93293ee6650c4d0ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Pages_account_discussions), @"mvc.1.0.razor-page", @"/Pages/account-discussions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd5d17e87fc587ad70c49f93293ee6650c4d0ea", @"/Pages/account-discussions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756a50ae9e1ae6c5163d777dbb71451efc16de6f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_account_discussions : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Обсуждения";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav class=""account-nav"">
    <div class=""account-nav-link-container"">
        <div class=""account-nav-link"" onclick=""settings()"">Настройки</div>
    </div>
    <div class=""account-nav-link-container"">
        <div class=""account-nav-link"" onclick=""myArticles()"">Избранные статьи</div>
    </div>
    <div class=""account-nav-link-container"">
        <div class=""account-nav-link account-active"" onclick=""myDiscussions()"">Мои обсуждения</div>
    </div>
</nav>

<div class=""account-discussions"">

");
#nullable restore
#line 23 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
     if (Model.discussions.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
         foreach (var e in Model.discussions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 755, "\"", 794, 2);
            WriteAttributeValue("", 762, "/discussion?open=", 762, 17, true);
#nullable restore
#line 27 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
WriteAttributeValue("", 779, e.DiscussionId, 779, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"forum-discussion-item\">\r\n                <div class=\"forum-discussion-container\">\r\n                    <div class=\"forum-discussion-headline\">");
#nullable restore
#line 29 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
                                                      Write(e.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"forum-discussion-text\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
                   Write(e.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-discussion-info\">");
#nullable restore
#line 33 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
                                                 Write(e.PersonCreateLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 33 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
                                                                       Write(e.TimeCreate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 36 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"text-align: center\">Вы еще не комментировали и не создавали обсуждения :(</p>\r\n");
#nullable restore
#line 41 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\account-discussions.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.account_discussions> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.account_discussions> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.account_discussions>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.account_discussions Model => ViewData.Model;
    }
}
#pragma warning restore 1591
