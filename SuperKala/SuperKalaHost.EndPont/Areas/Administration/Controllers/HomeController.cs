using Microsoft.AspNetCore.Mvc;

namespace SuperKalaHost.EndPont.Areas.Administration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
