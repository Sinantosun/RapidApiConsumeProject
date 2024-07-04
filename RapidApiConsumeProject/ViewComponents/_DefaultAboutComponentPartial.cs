using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsumeProject.ViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
