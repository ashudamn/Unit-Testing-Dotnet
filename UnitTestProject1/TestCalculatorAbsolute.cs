using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCalculatorAbsolute
    {

        private static CSharpCalculator.Calculator calculator;
            
        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }
        [TestMethod]
        public void TestAbsoluteInt()
        {
            Assert.AreEqual(2, calculator.Abs(-2));
        }
        [TestMethod]
        public void TestAbsoluteDouble()
        {
            Assert.AreEqual(1, calculator.Abs(-1.0));   
        }
        [TestMethod]
        public void TestAbsoluteZeroInt()
        {
            Assert.AreEqual(0, calculator.Abs(0));  
        }
        [TestMethod]
        public void TestAbsoluteZeroFloat()
        {
            Assert.AreEqual(0.0, calculator.Abs(0.0));
        }

    }
}
