using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.UI.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManager newsletterManager = new NewsletterManager(new EfNewsletterDal());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(Newsletter newsletter)
        {
            newsletter.MailStatus = true;
            newsletterManager.TAdd(newsletter);
            return PartialView();
        }
    }
}
