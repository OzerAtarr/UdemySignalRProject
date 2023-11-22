using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.UILayoutComponents
{
    public class _UILayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
