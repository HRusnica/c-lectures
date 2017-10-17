using FlyByNightBank.Web.DAL;
using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers
{
    public class SurveyController : Controller
    {
        //private SurveySqlDAL dal = new SurveySqlDAL(); //<-- private variable to hold the DAL
        private ISurveyDAL dal; //<-- private variable to hold the DAL

        public SurveyController(ISurveyDAL surveyDal) //<-- constructor to inject the surveyDAL
        {
            this.dal = surveyDal; //<-- assigns injected DAL to the private variable
        }

        // GET Survey/TakeSurvey
        [HttpGet]
        public ActionResult TakeSurvey()
        {
            // Instantiate the Survey model
            // Return a TakeSurvey view (and pass in the model)

            Survey model = new Survey();
            return View("TakeSurvey", model);
        }

        // POST: Survey/TakeSurvey
        [HttpPost] //<-- this is a POST METHOD ONLY
        public ActionResult TakeSurvey(Survey completedSurvey)
        {
            // Give completed survey to a dal
            // Return the SurveyResult view

            dal.SaveSurvey(completedSurvey);
            //return View("SurveyResult");
            return RedirectToAction("SurveyResult");
        }

        // GET: /Survey/SurveyResult
        public ActionResult SurveyResult()
        {
            return View("SurveyResult");
        }

        
    }
}