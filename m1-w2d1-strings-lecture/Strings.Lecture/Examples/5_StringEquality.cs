using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Lecture.Examples
{
    [TestClass]
    public class StringEquality
    {
        /* Check to see if two strings are equal                  
         * 
         * "C#" & "c#" -> false
         * "C#" & "C#" -> true
         * "Hello" & "Helo" -> false
         */
        public bool ReturnTrueIfStringsAreEqual(string str1, string str2)
        {
            return false;
        }

        /*
         * Check to see if two strings are equal (case-insensitive)
         * (hint: look at UpperCasing or LowerCasing the strings)
         * 
         * "C#" & "c#" -> true
         * "C#" & "C#" -> true
         * "Hello" & "Helo" -> false
         */
        public bool ReturnTrueIfStringsAreEqualCaseInsensitive(string str1, string str2)
        {            
            return false;
        }

        /*
         * Try another way using .Equals()
         * 
         * "C#" & "c#" -> true
         * "C#" & "C#" -> true
         * "Hello" & "Helo" -> false
         */
        public bool ReturnTrueIfStringsAreEqualCaseInsensitiveX2(string str1, string str2)
        {
            return false;
        }



        // --------------- TESTS -------------
        // ------------ DO NOT MODIFY --------
        [TestMethod]
        public void Ex5_1_CheckForStringEquality()
        {
            Assert.AreEqual(false, this.ReturnTrueIfStringsAreEqual("C#", "c#"));
            Assert.AreEqual(true, this.ReturnTrueIfStringsAreEqual("Hello", "Hello"));
            Assert.AreEqual(false, this.ReturnTrueIfStringsAreEqual("Hello", "Helo"));
        }

        [TestMethod]
        public void Ex5_2_CheckForStringEquality_CaseInsensitive()
        {
            Assert.AreEqual(true, this.ReturnTrueIfStringsAreEqual("C#", "c#"));
            Assert.AreEqual(true, this.ReturnTrueIfStringsAreEqual("Hello", "Hello"));
            Assert.AreEqual(false, this.ReturnTrueIfStringsAreEqual("Hello", "Helo"));
        }

        [TestMethod]
        public void Ex5_3_CheckForStringEquality_CaseInsensitive()
        {
            Assert.AreEqual(true, this.ReturnTrueIfStringsAreEqual("C#", "c#"));
            Assert.AreEqual(true, this.ReturnTrueIfStringsAreEqual("Hello", "Hello"));
            Assert.AreEqual(false, this.ReturnTrueIfStringsAreEqual("Hello", "Helo"));
        }
    }
}
