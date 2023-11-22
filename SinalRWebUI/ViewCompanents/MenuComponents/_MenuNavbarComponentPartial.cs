using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.MenuComponents
{
    public class _MenuNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
