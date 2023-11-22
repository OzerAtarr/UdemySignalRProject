using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.LayoutComponents
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
