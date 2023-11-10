using Microsoft.AspNetCore.Mvc;

namespace SinalRWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
