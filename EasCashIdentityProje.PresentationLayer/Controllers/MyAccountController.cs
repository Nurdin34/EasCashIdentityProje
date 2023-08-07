using Microsoft.AspNetCore.Mvc;

namespace EasCashIdentityProje.PresentationLayer.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
