using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class SubtractionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            SubtractionCalculator calculator = new SubtractionCalculator();
            Assert.AreEqual(8, calculator.Calculate(10, 2));
            Assert.AreEqual(12, calculator.Calculate(13, 1));
            Assert.AreEqual(5, calculator.Calculate(5.3, 0.3));
        }
    }
}