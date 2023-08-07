using Microsoft.AspNetCore.Mvc;

namespace EasCashIdentityProje.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
