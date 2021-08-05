using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sherlock_Valid_String;

namespace Valid_String_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isvalidTrue()
        {
            string sherlock = "abcba";
            string sherlock1 = "abcba";
            string sherlock2 = "abcba";
            string sherlock3 = "abcba";
            string sherlock4 = "abcba";


            string expected = "YES";

            string result = Valid_String.isValid(sherlock);

            Assert.AreEqual(expected, result);

            
        }

    }
}
