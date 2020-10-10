using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roy_Cv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Skill()
        {
            ViewBag.Message = "About My Skill";

            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "My Educational Back Ground";

            return View();
        }

        public ActionResult Personal()
        {
            ViewBag.Message = "My Personal Details";

            return View();
        }

        public ActionResult Exp()
        {
            ViewBag.Message = "My Experience & Projects";

            return View();
        }

        public ActionResult Reference()
        {
            ViewBag.Message = "My References";

            return View();
        }

    }
}