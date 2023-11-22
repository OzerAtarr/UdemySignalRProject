using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.LayoutComponents
{
	public class _LayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
