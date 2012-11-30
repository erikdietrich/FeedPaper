using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeedPaper.Controllers
{
    public class HomeController : Controller
    {
        public const string AboutFeedpaperDescription = "Feed Paper is the 21st century equivalent of a newspaper.  Add RSS feeds and Feed Paper will assemble them into a newspaper for you.  It's that simple.";

        public ActionResult Index()
        {
            ViewBag.Message = "Coming soon, and, when it does, not looking suspciously like the default MVC site.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Description = AboutFeedpaperDescription;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
