using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.UI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
