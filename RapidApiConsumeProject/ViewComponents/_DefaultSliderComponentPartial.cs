using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsumeProject.ViewComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
