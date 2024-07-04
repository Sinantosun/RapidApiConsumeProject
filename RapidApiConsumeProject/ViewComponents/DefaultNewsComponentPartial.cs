using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsumeProject.ViewComponents
{
    public class DefaultNewsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }

}
