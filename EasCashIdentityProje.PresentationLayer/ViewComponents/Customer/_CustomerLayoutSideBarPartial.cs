using Microsoft.AspNetCore.Mvc;

namespace EasCashIdentityProje.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutSideBarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
