$(function () {

    //8. Let me figure this out and post it
    $("#chkEmail").on("change", function (e) {
        $("#applicationForm").valid();
    });

    // Validate takes an object, not a function
    // Objects in javascript use { .. } notation and are the same as key / value pairs
    // 1. Wire up the validation rules for the #applicationForm
    $("#applicationForm").validate({
        rules: {
            //2. Add a rule for fName field
            fName: {
                required: true, //<-- makes it required
                maxlength: 20,                
            },
            password: {
                martysRule: true //<-- 5. Make our own rule
            },
            //7. Add a conditional rule if the contact box is checked
            emailAddr: {
                required: {
                    depends: function (element) {
                        return $("#chkEmail").is(":checked");
                    }
                }
            }
        },
        //4. Add a custom message for maxlength
        messages: {
            fName: {
                maxlength: "Your first name is too long"
            }
        },
        //3. Define a custom error class
        //      and define custom styles
        errorClass: "error"
    });
});

//6. Implement Martys Rule
//Create a custom validation rule that only permits email addresses that end with @techelevator.com
//https://jqueryvalidation.org/jQuery.validator.addMethod
$.validator.addMethod("martysRule", function (value) {
    // must return true or false
    return value.match(/[A-Z]/) && value.match(/[a-z]/) && value.match(/\d/);  //check for one capital letter, one lower case letter, one num
}, "Password is too weak for Marty");