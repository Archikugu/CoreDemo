using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.UI.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
