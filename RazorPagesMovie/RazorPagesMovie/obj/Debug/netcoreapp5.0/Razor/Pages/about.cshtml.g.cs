#pragma checksum "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\about.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e0d998e537685dd86c83dcb36bd08dd335203c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Pages_about), @"mvc.1.0.razor-page", @"/Pages/about.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0d998e537685dd86c83dcb36bd08dd335203c4", @"/Pages/about.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756a50ae9e1ae6c5163d777dbb71451efc16de6f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_about : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Allah\Desktop\Semestrovka\SemestrovkaHistory\RazorPagesMovie\RazorPagesMovie\Pages\about.cshtml"
  
    Layout = "Shared/_Layout";
    ViewData["Title"] = "О нас";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"">
    <div class=""main-block-about"">

        <div class=""about-team"">
            <div class=""about-headline"">Наша команда</div>

            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <img class=""d-block"" src=""../images/author1.jpeg"" alt=""Первый слайд"">
                        <div class=""carousel-caption d-md-block"">
                            <h3>Наталья Ростова</h3>
                            <p>Главный редактор</p>
                        </div>
                 ");
            WriteLiteral(@"   </div>
                    <div class=""carousel-item"">
                        <img class=""d-block"" src=""../images/author2.jpg"" alt=""Второй слайд"">
                        <div class=""carousel-caption d-md-block"">
                            <h3>Илья Обломов</h3>
                            <p>Неглавный редактор</p>
                        </div>
                    </div>
                    <div class=""carousel-item"">
                        <img class=""d-block"" src=""../images/author3.jpg"" alt=""Третий слайд"">
                        <div class=""carousel-caption d-md-block"">
                            <h3>Александр Чацкий</h3>
                            <p>Журналист</p>
                        </div>
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-");
            WriteLiteral(@"only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>

        <div class=""our-contacts"">
            <div class=""about-headline"">Наши контакты</div>
            <div class=""contacts-div"">
                <div>
                    <div class=""contact-item contact-type"">Телефон:&nbsp;</div>
                    <div class=""contact-item contact-copy"" title=""Скопировать"">+7 (321) 123-77-07</div>
                </div>
                <div>
                    <div class=""contact-item contact-type"">Почта:&nbsp;</div>
                    <div class=""contact-item contact-copy"" title=""Скопировать"">history@gmail.com</div>
                </div>
                <div>
                    <div class=""con");
            WriteLiteral(@"tact-item contact-type"">Телеграм:&nbsp;</div>
                    <div class=""contact-item contact-copy"" title=""Скопировать"">hiStory_tg</div>
                </div>
            </div>
        </div>

    </div>
</main>

<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx"" crossorigin=""anonymous""></script>

");
            DefineSection("Header", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"" integrity=""sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"" crossorigin=""anonymous"">
    <script src=""/js/copy-contact.js""></script>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Footer", async() => {
                WriteLiteral(@"
    <script src=""/js/back-to-top.js""></script>
    
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx"" crossorigin=""anonymous""></script>
        
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.about> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.about> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.about>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.about Model => ViewData.Model;
    }
}
#pragma warning restore 1591
