using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.DefaultComponents
{
    public class _DefaultBookATableComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
