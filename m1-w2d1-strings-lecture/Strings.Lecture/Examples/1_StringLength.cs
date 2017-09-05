using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Lecture.Examples
{
    [TestClass]
    public class StringLength
    {
        /*  Strings are arrays of characters. Like arrays, they are fixed and have a .Length property
         *  that you can use to retrieve how many characters there are.
         *  
         *  Make the code below return the length of the string
         *  "Hello" -> 5
         *  "C#" -> 2
         */
        public int ReturnLengthOfTheString(string str)
        {
            return 0;
        }



        // --------------- TESTS -------------
        // ------------ DO NOT MODIFY --------

        [TestMethod]
        public void Ex1_ReturnLengthOfTheString()
        {
            Assert.AreEqual(5, this.ReturnLengthOfTheString("Hello"), "Hello should return 5");
            Assert.AreEqual(2, this.ReturnLengthOfTheString("C#"), "C# should return 2");
            Assert.AreEqual(0, this.ReturnLengthOfTheString(""), "Empty string \"\" should return 0");
        }
    }
}
