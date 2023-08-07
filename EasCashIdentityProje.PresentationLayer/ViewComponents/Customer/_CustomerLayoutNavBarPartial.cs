using Microsoft.AspNetCore.Mvc;

namespace EasCashIdentityProje.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavBarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
