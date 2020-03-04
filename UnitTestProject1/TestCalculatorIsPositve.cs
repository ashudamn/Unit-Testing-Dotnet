using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUnitTestProject
{
    [TestClass]
    public class TestCalculatorIsPositve
    {
        private static CSharpCalculator.Calculator calculator;

        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void TestIsPositiveWithPositiveInput()
        {
            Assert.IsTrue(calculator.isPositive(1.0));
        }
        [TestMethod]
        public void TestIsPositiveWithNegativeInput()
        {
            Assert.IsFalse(calculator.isPositive(-1.0));
        }
    }
}
