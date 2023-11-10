using Microsoft.AspNetCore.Mvc;

namespace SinalRWebUI.ViewCompanents.LayoutComponents
{
    public class _LayoutHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
