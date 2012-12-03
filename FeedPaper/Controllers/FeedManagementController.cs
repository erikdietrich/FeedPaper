using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeedPaper.Controllers
{
    public class FeedManagementController : Controller
    {
        public ActionResult AddFeed()
        {
            return View();
        }
    }
}