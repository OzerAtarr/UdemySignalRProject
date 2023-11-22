using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.LayoutComponents
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
