using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.UI.Controllers
{
	public class BlogController : Controller
	{
		BlogManager blogManager = new BlogManager(new EfBlogDal());
		public IActionResult Index()
		{
			var values = blogManager.TGetList();
			return View(values);
		}
	}
}
