using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Lecture.Examples
{
    [TestClass]
    public class FindingStringsInStrings
    {
        /*
         * Sometimes we want to see if one string contains another string.         
         * In order to do that we can use the .Contains(string) method.
         * 
         * Change the method below to return true or false if a string 
         * contains the word "Tech"
         * 
         * "Tech Elevator is a coding school" -> true
         * "C# is one of the most popular languages in tech." -> false
         * "Technically, I don't know." -> true        
         */ 
        public bool ReturnIfStringContainsAnotherString(string str)
        {
            return false;
        }

        /*
         * If we need to find the location of a string in another string,
         * we can use the .IndexOf(string) method.
         * 
         * Make the method return the position (index) of the string "Tech" 
         * in string str.
         * 
         * "Tech Elevator is a coding school" -> 0
         * "C# is one of the most popular languages in tech." -> -1
         * "Do you attend Tech Elevator" -> 14
         */
        public int ReturnPositionOfStringInAString(string str)
        {
            return 0;
        }


        // --------------- TESTS -------------
        // ------------ DO NOT MODIFY --------

        [TestMethod]
        public void Ex4_1_FindingIfAStringContainsAString()
        {
            Assert.AreEqual(true, this.ReturnIfStringContainsAnotherString("Tech Elevator is a coding school"));
            Assert.AreEqual(false, this.ReturnIfStringContainsAnotherString("C# is one of the most popular languages in tech."));
            Assert.AreEqual(true, this.ReturnIfStringContainsAnotherString("Technically, I don't know."));
        }

        [TestMethod]
        public void Ex4_2_FindingThePositionOfAString()
        {
            Assert.AreEqual(0, this.ReturnPositionOfStringInAString("Tech Elevator is a coding school"));
            Assert.AreEqual(-1, this.ReturnPositionOfStringInAString("C# is one of the most popular languages in tech."));
            Assert.AreEqual(14, this.ReturnPositionOfStringInAString("Do you attend Tech Elevator"));
        }

    }
}
