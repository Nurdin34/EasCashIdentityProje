using Microsoft.AspNetCore.Mvc;

namespace EasCashIdentityProje.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
