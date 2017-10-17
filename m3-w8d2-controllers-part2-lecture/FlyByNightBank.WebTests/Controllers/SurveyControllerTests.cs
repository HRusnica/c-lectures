using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlyByNightBank.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using FlyByNightBank.Web.DAL;
using Moq;
using FlyByNightBank.Web.Models;
using FlyByNightBank.WebTests.BodyDouble;

namespace FlyByNightBank.Web.Controllers.Tests
{

    /*
    * The objective of these tests will be to test each of the controller actions and check
    * to see if they return the correct view, redirect to the correct action, or save to our database.
    * 
    * One of our tests relies on a ISurveyDAL in order to save the survey. We can "mock" out an ISurveyDAL
    * so that it can be passed in and used in place of the real SQL DAL.
    */
    [TestClass()]
    public class SurveyControllerTests
    {
        [TestMethod]
        public void TakeSurveyAction_ReturnsCorrectViewAndModel()
        {
            //Arrange
            SurveyBodyDouble fakeDal = new SurveyBodyDouble();
            SurveyController controller = new SurveyController(fakeDal);

            //Act
            ActionResult result = controller.TakeSurvey();

            //Assert
            //Test to see if result is of type ViewResult
            Assert.IsTrue(result.GetType() == typeof(ViewResult));

            //Cast result into a ViewResult
            ViewResult vr = (ViewResult)result;
            Assert.AreEqual("TakeSurvey", vr.ViewName); //<-- check the name of the view

            // Check if the model is a Survey, not anything else
            Assert.IsTrue(vr.Model.GetType() == typeof(Survey));
        }

        [TestMethod]
        public void SurveyAction_ReturnsCorrectView()
        {
            //Arrange
            SurveyBodyDouble fakeDal = new SurveyBodyDouble();
            SurveyController controller = new SurveyController(fakeDal);
            Survey fakeSurvey = new Survey();

            //Act
            ActionResult result = controller.SurveyResult(fakeSurvey);

            //Assert
            //Test to see if result is of type ViewResult
            Assert.IsTrue(result.GetType() == typeof(ViewResult));

            //Cast result into a ViewResult
            ViewResult vr = (ViewResult)result;
            Assert.AreEqual("SurveyResult", vr.ViewName); //<-- check the name of the view

        }



    }
}