#pragma checksum "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\discussion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f5b848d062d6c1c4c621e1e7862b0328e00488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Pages_discussion), @"mvc.1.0.razor-page", @"/Pages/discussion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f5b848d062d6c1c4c621e1e7862b0328e00488", @"/Pages/discussion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bffd98f02597e6a09295a2131188dc64093be78", @"/Pages/_ViewImports.cshtml")]
    public class Pages_discussion : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\discussion.cshtml"
  
    Layout = "Shared/_Layout";
    ViewData["Title"] = "Главная";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"">

    <div class=""main-block-discussion"">

        <div class=""discussion-div"">
            <div class=""discussion-headline"">Кто, если не Путин?</div>
            <div class=""discussion-text"">
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Illo consectetur autem, inventore nulla doloribus tempore iusto nobis cumque rem dignissimos? Numquam velit corporis minima repellendus? Corporis atque voluptates ducimus sit?
                <br>
                Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eum sunt odio debitis praesentium rerum eligendi nemo! Animi quod nisi explicabo, dolor laudantium, culpa fugit, soluta voluptates mollitia vitae deserunt numquam.
            </div>
            <div class=""discussion-info"">VovkaRussia777, 22.05.20</div>
        </div>

        <div class=""comments-div"">

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f5b848d062d6c1c4c621e1e7862b0328e004885005", async() => {
                WriteLiteral("\r\n                <textarea placeholder=\"Комментарий\"></textarea>\r\n                <button class=\"add-comment\" type=\"submit\">Добавить комментарий</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            <div class=""all-comments"">
                <div class=""comment"">
                    <div class=""comment-text"">Реально круто! РОССИЯ ВПЕРЁД!!! Люблю историю и Путина!</div>
                    <div class=""comment-info"">Patriarch, 07.12.20</div>
                </div>
                <div class=""comment"">
                    <div class=""comment-text"">Реально круто! РОССИЯ ВПЕРЁД!!! Люблю историю и Путина!</div>
                    <div class=""comment-info"">Patriarch, 07.12.20</div>
                </div>
                <div class=""comment"">
                    <div class=""comment-text"">Реально круто! РОССИЯ ВПЕРЁД!!! Люблю историю и Путина!</div>
                    <div class=""comment-info"">Patriarch, 07.12.20</div>
                </div>
                <div class=""comment"">
                    <div class=""comment-text"">Реально круто! РОССИЯ ВПЕРЁД!!! Люблю историю и Путина!</div>
                    <div class=""comment-info"">Patriarch, 07.12.20</div>
                </div>
");
            WriteLiteral(@"                <div class=""comment"">
                    <div class=""comment-text"">Реально круто! РОССИЯ ВПЕРЁД!!! Люблю историю и Путина!</div>
                    <div class=""comment-info"">Patriarch, 07.12.20</div>
                </div>
                <div class=""comment"">
                    <div class=""comment-text"">Реально круто! РОССИЯ ВПЕРЁД!!! Люблю историю и Путина!</div>
                    <div class=""comment-info"">Patriarch, 07.12.20</div>
                </div>
                <div class=""comment"">
                    <div class=""comment-text"">Реально круто! РОССИЯ ВПЕРЁД!!! Люблю историю и Путина!</div>
                    <div class=""comment-info"">Patriarch, 07.12.20</div>
                </div>
                <div class=""comment"">
                    <div class=""comment-text"">Реально круто! РОССИЯ ВПЕРЁД!!! Люблю историю и Путина!</div>
                    <div class=""comment-info"">Patriarch, 07.12.20</div>
                </div>
            </div>

        </div>

    ");
            WriteLiteral("</div>\r\n\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.discussion> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.discussion> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.discussion>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.discussion Model => ViewData.Model;
    }
}
#pragma warning restore 1591
