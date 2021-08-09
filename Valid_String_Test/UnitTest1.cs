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

            string result1 = Valid_String.isValid(sherlock1);

            string result2 = Valid_String.isValid(sherlock2);

            string result3 = Valid_String.isValid(sherlock3);

            string result4 = Valid_String.isValid(sherlock4);

    



            Assert.AreEqual(expected, result, result1, result2, result3,result4);

           

            
        }

        [TestMethod]
        public void isValidFalse()
        {
            string expected1 = "NO";

            string sherlock5 = "abc";

            string result5 = Valid_String.isValid(sherlock5);


            Assert.AreNotEqual(expected1, result5);




        }

    }
}
