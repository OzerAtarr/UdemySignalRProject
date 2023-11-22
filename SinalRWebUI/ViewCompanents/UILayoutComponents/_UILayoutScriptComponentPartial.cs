using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.UILayoutComponents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
