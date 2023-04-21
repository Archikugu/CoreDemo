using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.UI.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogDal());
		public IViewComponentResult Invoke()
		{
			var values = blogManager.GetBlogListWithWriter(1);
			return View(values);
		}
	}
}
