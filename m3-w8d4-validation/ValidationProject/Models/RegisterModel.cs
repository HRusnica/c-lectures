using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationProject.Models
{
    //4. Create a model that will hold our data
    public class RegisterModel
    {
        //5. Add the properties
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string ConfirmPassword { get; set; }

        //13. Add Validation Rules
        //      then go enforce validation in controller
        [Required(ErrorMessage = "Enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You need a password")]
        [RegularExpression("^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$", ErrorMessage = "your password sucks")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}