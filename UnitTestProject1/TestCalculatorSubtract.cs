using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCalculatorSubtract
    {
        private static CSharpCalculator.Calculator calculator;

        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void TestSubtractWithPositiveResult()
        {
            Assert.AreEqual(1.0,calculator.Sub(3,2));
        }
        [TestMethod]
        public void TestSubtractWithNegativeResult()
        {
            Assert.AreEqual(-1.0, calculator.Sub(2, 3));
        }
        [TestMethod]
        public void TestSubtractWithZeroResult()
        {
            Assert.AreEqual(0, calculator.Sub(2.0, 2.0));
        }

    }
}
