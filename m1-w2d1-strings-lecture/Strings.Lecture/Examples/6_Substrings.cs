using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Lecture.Examples
{
    [TestClass]
    public class Substrings
    {
        /*
         * .Substring() is a string method. There are two variations
         * of it and their objective is to retrieve a substring from a 
         * larger string.
         * 
         */

        /*
         * "" -> ""
         * "Hi" -> "i"
         * "Mr. John Smith" -> "n Smith"
         * "Jane Austin" -> "ustin"
         */
        public string ReturnLastHalfOfTheString(string str)
        {
            return "";
        }
        

        /*
         * "Jane Austin" -> "ane"
         * "J Edgar Hoover -> " Ed"
         */ 
        public string Return2ndThru4thCharacters(string str)
        {
            return "";            
        }

        // --------------- TESTS -------------
        // ------------ DO NOT MODIFY --------

        [TestMethod]
        public void Ex_6_1_ReturnLastHalfOfTheString()
        {
            Assert.AreEqual("", this.ReturnLastHalfOfTheString(""));
            Assert.AreEqual("i", this.ReturnLastHalfOfTheString("Hi"));
            Assert.AreEqual("n Smith", this.ReturnLastHalfOfTheString("Mr. John Smith"));
            Assert.AreEqual("Austin", this.ReturnLastHalfOfTheString("Jane Austin"));
        }

        [TestMethod]
        public void Ex_6_2_Return2ndThru4thCharacters()
        {
            Assert.AreEqual("ane", this.Return2ndThru4thCharacters("Jane Austin"));
            Assert.AreEqual(" Ed", this.Return2ndThru4thCharacters("J Edgar Hoover"));
        }


    }
}
