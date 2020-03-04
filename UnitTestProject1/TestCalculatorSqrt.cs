using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUnitTestProject
{
    [TestClass]
    public class TestCalculatorSqrt
    {
        private static CSharpCalculator.Calculator calculator;

        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void TestSqrtForPerfectSquare()
        {
            Assert.AreEqual(4.0, calculator.Sqrt(16));
        }
        [TestMethod]
        public void TestSqrtForDouble()
        {
            Assert.AreEqual(Math.Sqrt(10), calculator.Sqrt(10));
        }

    }
}
