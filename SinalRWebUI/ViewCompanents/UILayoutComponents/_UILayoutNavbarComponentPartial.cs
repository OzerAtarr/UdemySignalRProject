using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.UILayoutComponents
{
    public class _UILayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
