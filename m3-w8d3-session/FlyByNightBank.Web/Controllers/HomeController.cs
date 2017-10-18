using FlyByNightBank.Web.DAL;
using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRateDAL dal;

        public HomeController(IRateDAL rateDal)
        {
            this.dal = rateDal;
        }

        // GET: /
        // GET: Home/
        // GET: Home/Index
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: Home/WhyFlyByNight
        public ActionResult WhyFlyByNight()
        {
            return View("WhyFlyByNight");
        }

        // GET: Home/ViewRates?zipcode=12345
        public ActionResult ViewRates(string zipcode)
        {
            // If the user provided a zip code, set it in session
            if (!String.IsNullOrEmpty(zipcode))
            {
                Session["visitor_zipcode"] = zipcode; //<-- Sets the zip code into session
                                                      //    under the key "visitor_zipcode"
            }

            // Get the zipcode out of session but cast it as a string
            zipcode = Session["visitor_zipcode"] as string;


            InterestRateModel model = dal.GetRates(zipcode);
            return View("ViewRates", model);
        }





        
    }
}