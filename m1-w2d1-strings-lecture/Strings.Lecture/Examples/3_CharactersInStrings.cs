using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Lecture.Examples
{
    [TestClass]
    public class CharactersInStrings
    {
        /* Strings are arrays of characters. Change the code below
         * so that it returns the first character of string str.         
         * 
         * "Hello" -> 'H'
         * "C#" -> 'C'
         */
        public char ReturnFirstCharacterInString(string str)
        {
            return '\0'; //<-- null character
        }

        /* Because strings are arrays of characters, if we want
         * the last character in the string we follow the same pattern
         * of how we get the last element in an array.
         * 
         * "Hello" -> 'o'
         * "C#" -> '#'
         */ 
         public char ReturnLastCharacterInString(string str)
        {
            return '\0';
        }



        // --------------- TESTS -------------
        // ------------ DO NOT MODIFY --------
        [TestMethod]
        public void Ex3_1_ReturnFirstCharacterInString()
        {
            Assert.AreEqual('H', this.ReturnFirstCharacterInString("Hello"), "First character in Hello is 'H'");
            Assert.AreEqual('C', this.ReturnFirstCharacterInString("Hello"), "First character in C# is 'C'");
        }

        [TestMethod]
        public void Ex3_2_ReturnLastCharacterInString()
        {
            Assert.AreEqual('o', this.ReturnFirstCharacterInString("Hello"), "Last character in Hello is 'o'");
            Assert.AreEqual('#', this.ReturnFirstCharacterInString("Hello"), "Last character in C# is '#'");
        }

    }
}
