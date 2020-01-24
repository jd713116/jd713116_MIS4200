using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jd713116_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Info About Me";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact Info";

            return View();
        }
    }
}