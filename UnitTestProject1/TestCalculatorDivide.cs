using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUnitTestProject
{
    [TestClass]
    public class TestCalculatorDivide
    {
        private static CSharpCalculator.Calculator calculator;

        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }
        [TestMethod]
        public void TestDividePositive()
        {
            Assert.AreEqual(3.5, calculator.Divide(7,2));
        }
        [TestMethod]
        public void TestDivideNegative()
        {
            Assert.AreEqual(-3.5, calculator.Divide(-7, 2));
        }
        [TestMethod]
        public void TestDivideByZero()
        {
            Assert.IsTrue(Double.IsInfinity(calculator.Divide(-7, 0)));
        }

    }
}
