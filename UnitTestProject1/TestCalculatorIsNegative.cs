using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCalculatorIsNegative
    {
        private static CSharpCalculator.Calculator calculator;

        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }
        [TestMethod]
        public void TestIsNegativeWithPositiveInput()
        {
            Assert.IsFalse(calculator.isNegative(1.0));
        }
        [TestMethod]
        public void TestIsNegativeWithNegativeInput()
        {
            Assert.IsTrue(calculator.isNegative(-1.0));
        }

    }
}
