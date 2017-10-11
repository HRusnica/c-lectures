using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // GET: Home/Index
        public string Index()
        {
            return "Hello World!";
        }

        // GET: Home/DateTime <-- URL to open to call this action
        public string DateTime()
        {
            return System.DateTime.Now.ToString();
        }

        // GET: Home/Stuff <-- URL to invoke this action
        public ActionResult Stuff()
        {
            return View("Stuff");
        }

        public ActionResult Message()
        {
            return View("Message");
        }

        public ActionResult MetricToImperial()
        {
            return View("MetricToImperial");
        }


    }
}