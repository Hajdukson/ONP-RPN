using ONP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void Resoult42()
        {
            var onplogic = new ONPLogic("21 21 +");

            double result = onplogic.Calculator();

            Assert.AreEqual(42, result);
        }
        [TestMethod]
        public void ResoultMinus180()
        {
            var onplogic = new ONPLogic("20 1 10 - *");

            double result = onplogic.Calculator();

            Assert.AreEqual(-180, result);
        }
        [TestMethod]
        public void AdvancedCalculation_Result40()
        {
            var onplogic = new ONPLogic("12 2 3 4 * 10 5 / + * +");

            double result = onplogic.Calculator();

            Assert.AreEqual(40, result);
        }
        [TestMethod]
        public void PowerIsWorkingCorrectly()
        {
            var onplogic = new ONPLogic("2 10 ^");

            double result = onplogic.Calculator();

            Assert.AreEqual(1024, result);
        }
        [TestMethod]
        public void AdvancedCalculationWithPower_Result1600()
        {
            var onplogic = new ONPLogic("12 2 3 4 * 10 5 / + * + 2 ^");

            double result = onplogic.Calculator();

            Assert.AreEqual(1600, result);
        }
    }
}