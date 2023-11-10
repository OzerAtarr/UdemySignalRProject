using Microsoft.AspNetCore.Mvc;

namespace SinalRWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
