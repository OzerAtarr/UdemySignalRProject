using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewCompanents.LayoutComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
