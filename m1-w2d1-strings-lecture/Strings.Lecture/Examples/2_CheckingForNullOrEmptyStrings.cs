using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Lecture.Examples
{
    [TestClass]
    public class NullStrings
    {
        /* Strings are reference types. The value for a reference type holds the memory address
         * where the data can be found. If the reference variable doesn't point to a location in
         * memory, we say it is 'null'.
         * 
         * Using the static method String.IsNullOrEmpty(str) make the method below return 
         * true if the string passed in has a length 0 (empty string) or is null.
         * 
         * "Hello" -> false
         * "" -> true
         * null -> true
         */
        public bool CheckIfStringIsNullOrEmpty(string str)
        {
            return false;
        }



        // --------------- TESTS -------------
        // ------------ DO NOT MODIFY --------

        [TestMethod]
        public void Ex2_ReturnIfStringIsNullOrEmpty()
        {
            Assert.AreEqual(false, this.CheckIfStringIsNullOrEmpty("Hello"), "Hello should return false");
            Assert.AreEqual(true, this.CheckIfStringIsNullOrEmpty(""), "Empty string should return true");
            Assert.AreEqual(true, this.CheckIfStringIsNullOrEmpty(null), "Null string should return true");
        }
    }
}
