using FlyByNightBank.Web.Models.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers
{

    public class CalculatorsController : Controller
    {                                
        // GET: Calculators/CompoundInterest
        public ActionResult CompoundInterest()
        {
            CompoundInterestModel model = new CompoundInterestModel();
            return View("CompoundInterest", model);
        }

        // GET: Calculators/CompoundInterestResult?Principal={0}&NumberOfYears={1}&InterestRate={2}
        // double principal, int numberOfYears, double interestRate <--- ERROR PRONE due to Typos
        //public ActionResult CompoundInterestResult(double principal, int numberOfYears, double interestRate)
        //CompoundInterestModel model = new CompoundInterestModel()
        //{
        //    Principal = principal,
        //    NumberOfYears = numberOfYears,
        //    InterestRate = interestRate
        //};

        public ActionResult CompoundInterestResult(CompoundInterestModel input)
        {
            CompoundInterestModel model = input;
            return View("CompoundInterestResult", model);
        }

        // GET: Calculators/CreditCardPayoff
        // What the user users to fill out the form
        public ActionResult CreditCardPayoff()
        {
            CreditCardPayoffModel model = new CreditCardPayoffModel();
            return View("CreditCardPayoff", model);
        }

        // GET: Calculators/CreditCardPayoffResult?APR=1.2345&Balance=12345.00&MonthlyPayment=111.00
        // What the user sees after the form has been filled out
        public ActionResult CreditCardPayoffResult(CreditCardPayoffModel input)
        {
            CreditCardPayoffModel model = input;
            return View("CreditCardPayoffResult", model);
        }







        /*
        * Additional exercises to implement with students
        * if examples are needed.
        * Models already exist.
        */

        // GET: Calculators/MonthlyPayment
        public ActionResult MonthlyPayment()
        {
            throw new NotImplementedException();
        }

        // GET: Calculators/MonthlyPaymentResult
        public ActionResult MonthlyPaymentResult(MonthlyPaymentModel model)
        {
            throw new NotImplementedException();
        }


        

    }
}