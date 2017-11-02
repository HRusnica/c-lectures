//1. Let's practice creating objects

//1a. Creating an object literal
var person = {
    firstName: "Josh",
    lovesJavascript: true,
    cars: ["Subaru", "Chevy"],
    greeting: function () {
        return "Who misses C#?";
    }
};

//flexible but sloppy
var person2 = {
    fName: "John",
    lovesJS: false,
}


// loop through the properties on person
for (var i in person) {
    console.log(i + " is " + person[i]);
}


//person.teaches = "C#";

//1b. Creating a "class"
function Person(name, lovesJs) {
    this.firstName = name;
    this.lovesJavascript = lovesJs;
}

var josh = new Person("Josh", true);
var marty = new Person("Marty", false);
