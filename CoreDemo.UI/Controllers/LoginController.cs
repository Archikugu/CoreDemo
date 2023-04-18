using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
