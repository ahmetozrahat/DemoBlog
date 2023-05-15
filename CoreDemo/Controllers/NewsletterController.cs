using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManager newsletterManager = new NewsletterManager(new EFNewsletterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(Newsletter newsletter)
        {
            newsletter.MailStatus = true;
            newsletterManager.AddNewsletter(newsletter);
            return PartialView();
        }
    }
}
