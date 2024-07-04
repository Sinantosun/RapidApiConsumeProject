using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsumeProject.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
