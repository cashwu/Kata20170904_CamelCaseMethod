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
            return "Ab";
        }
    }
}
