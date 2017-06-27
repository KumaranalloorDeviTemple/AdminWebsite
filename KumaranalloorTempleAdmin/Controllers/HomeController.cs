using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kumaranalloordevitempleadminweb.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        //Vazhipadu
        [Authorize]
        public ActionResult Vazhipadu()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        //Vazhipadu
        [Authorize]
        public ActionResult Notification()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        // About 
        public ActionResult About()
        {
            ViewBag.Message = new string[] { @"Kumaranalloor Devi Temple Administration", @"Release Date: 28-Apr-17", @"Build: 1·ּ0·3" };
            return View();
        }

    }
}