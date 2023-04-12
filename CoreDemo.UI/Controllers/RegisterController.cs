using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.UI.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager writerManager = new WriterManager(new EfWriterDal());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			writer.WriterStatus = true;
			writer.WriterAbout = "DenemeTest";
			writerManager.WriterAdd(writer);
			return RedirectToAction("Index", "Blog");
		}

	}
}
