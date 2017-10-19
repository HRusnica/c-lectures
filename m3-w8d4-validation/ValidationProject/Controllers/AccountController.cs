using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationProject.Models;

namespace ValidationProject.Controllers
{
    //1. Create controller
    public class AccountController : Controller
    {

        //2. Create a Register Action to return the Empty Form
        [HttpGet] //<-- this is irrelevant because Get is the default
        public ActionResult Register()
        {
            // 2. Return Register View for Register Action
            //return View("Register", );

            //10. Create the RegisterModel and pass to the View
            RegisterModel model = new RegisterModel();
            return View("Register", model);
        }

        //3. Create a Register Action (POST) to process the Form
        //  -> Go to RegisterModel for #4
        [HttpPost]
        public ActionResult Register(RegisterModel model) //6. Pass the model into the action
        {
            //3. Create Register Action (POST)
            //RegisterModel input = model; <-- this line can be "dead to us"
            //return RedirectToAction("ThankYou");
            
            //14. Implement Validation Enforcement and then TEST
            if (!ModelState.IsValid)
            {
                return View("Register", model); // <-- Send back to the Register View
                                                //      with their previous entered data
            }
            else
            {
                // Send them to the ThankYou page
                return RedirectToAction("ThankYou");
            }
        }

        //7. Create the ThankYou Action to display a Thank You Page
        //  -> Go Create Views Register & ThankYou
        public ActionResult ThankYou()
        {
            return View("ThankYou");
        }
    }
}