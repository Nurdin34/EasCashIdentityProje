using Microsoft.AspNetCore.Mvc;

namespace EasCashIdentityProje.PresentationLayer.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
