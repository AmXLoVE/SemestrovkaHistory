using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace RazorPagesMovie.Pages
{
    public class Error : ViewComponent
    {
        public IViewComponentResult Invoke(string error)
        {
            return new HtmlContentViewComponentResult(
                new HtmlString(error));
        }
    }
}