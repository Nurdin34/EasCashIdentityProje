using Microsoft.AspNetCore.Mvc;

namespace EasCashIdentityProje.PresentationLayer.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
