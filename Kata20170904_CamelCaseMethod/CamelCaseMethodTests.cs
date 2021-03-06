﻿using System;
using System.Globalization;
using System.Linq;
using System.Text;
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

        [TestMethod]
        public void input_ab_bc_should_return_AbBc()
        {
            CameCaseShouldBe("AbBc", "ab bc");
        }

        [TestMethod]
        public void input__ab_bc_should_return_AbBc()
        {
            CameCaseShouldBe("AbBc", " ab bc");
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
            var newStr = str.Split(' ').Select(a => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(a));

            return string.Concat(newStr);
        }
    }
}
