using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.UI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToString());
            comment.CommentStatus = true;
            comment.BlogId = 2;
            commentManager.TAdd(comment);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = commentManager.GetList(id);
            return PartialView(values);
        }
    }
}
