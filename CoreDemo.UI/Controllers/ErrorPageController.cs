using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.UI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
