using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class TestCalculatorAdd
    {
        private static CSharpCalculator.Calculator calculator;

        [ClassInitialize]
        public static void TestInit(TestContext context)
        {
            calculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void TestAddPositiveDouble()
        {
            Assert.AreEqual(5.0, calculator.Add(2.0, 3.0));
            
        }

    }
}
