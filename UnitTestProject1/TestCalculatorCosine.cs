using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUnitTestProject
{
   
    [TestClass]
    public class TestCalculatorCosine
    {
        private static CSharpCalculator.Calculator calculator;

        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }
        [TestMethod]
        public void TestCosine()
        {
            Assert.AreEqual(Math.Cos(12),calculator.Cos(12));
        }

        [TestMethod]
        public void TestCosineZero()
        {
            Assert.AreEqual(Math.Cos(0), calculator.Cos(0));
        }
    }
}
