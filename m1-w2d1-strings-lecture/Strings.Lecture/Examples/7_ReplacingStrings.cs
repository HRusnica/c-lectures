using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Lecture.Examples
{
    [TestClass]
    public class ReplacingStrings
    {
        /* C# offers a method .Replace() to replace all occurrences
         * of a string with another string. It returns a new string.         
         */ 
        public string ReplaceAllOccurencesOfJava(string str)
        {
            return "";
        }

        // --------------- TESTS -------------
        // ------------ DO NOT MODIFY --------

        [TestMethod]
        public void Ex7_ReplaceAllOccurrencesOfAString()
        {
            Assert.AreEqual("C# Rocks", this.ReplaceAllOccurencesOfJava("Java Rocks"));
            Assert.AreEqual("The best language is C#", this.ReplaceAllOccurencesOfJava("The best language is Java"));
        }

    }
}
