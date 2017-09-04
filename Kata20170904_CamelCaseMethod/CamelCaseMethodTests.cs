using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170904_CamelCaseMethod
{
    [TestClass]
    public class CamelCaseMethodTests
    {
        [TestMethod]
        public void input_ab_should_return_Ab()
        {
            CameCaseShouldBe("Ab", "ab");
        }

        [TestMethod]
        public void input_bc_should_return_Bc()
        {
            CameCaseShouldBe("Bc", "bc");
        }

        private static void CameCaseShouldBe(string expected, string str)
        {
            var problem = new Problem();
            var actual = problem.CameCase(str);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Problem
    {
        public string CameCase(string str)
        {
            var charArray = str.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return string.Concat(charArray);
        }
    }
}
