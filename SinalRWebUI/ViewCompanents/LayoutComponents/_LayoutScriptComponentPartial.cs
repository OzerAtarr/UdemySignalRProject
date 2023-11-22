using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.LayoutComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
