using Microsoft.AspNetCore.Mvc;

namespace SuperKalaHost.EndPoint.Areas.Administration.Controllers
{

    [Area("Administration")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
