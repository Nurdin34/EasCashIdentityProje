using EasCashIdentityProje.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasCashIdentityProje.PresentationLayer.Controllers
{
    [Authorize]
    public class MyAccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MyAccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async IActionResult Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            return View();
        }
    }
}
