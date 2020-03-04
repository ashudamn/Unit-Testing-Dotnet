using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUnitTestProject
{
    [TestClass]
    public class TestCalculatorMultiply
    {
        private static CSharpCalculator.Calculator calculator;

        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void TestMultiplySimilarSignParam()
        {
            Assert.AreEqual(7.0,calculator.Multiply(2.0,3.5));
        }
        [TestMethod]
        public void TestMultiplNegativeSignParam()
        {
            Assert.AreEqual(-7.0, calculator.Multiply(-2.0, 3.5));
        }
    }
}
