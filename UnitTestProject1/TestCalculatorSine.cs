using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUnitTestProject
{
    [TestClass]
    public class TestCalculatorSine
    {
        private static CSharpCalculator.Calculator calculator;

        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }
        [TestMethod]
        public void TestSine()
        {
            Assert.AreEqual(Math.Sin(10),calculator.Sin(10));
        }
    }
}
