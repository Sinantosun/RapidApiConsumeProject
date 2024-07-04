using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsumeProject.ViewComponents
{
    public class _DefaultSearchViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
