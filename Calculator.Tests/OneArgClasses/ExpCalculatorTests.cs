using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgClasses
{
    [TestFixture]
    public class ExpCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            ExpCalculator calculator = new ExpCalculator();
            Assert.AreEqual(148.413159102577, calculator.Calculate(5));
            Assert.AreEqual(1, calculator.Calculate(0));
        }
    }
}