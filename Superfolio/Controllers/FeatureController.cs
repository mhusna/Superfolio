using Microsoft.AspNetCore.Mvc;

namespace Superfolio.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
