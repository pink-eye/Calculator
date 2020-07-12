using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            MultiplyCalculator calculator = new MultiplyCalculator();
            Assert.AreEqual(215, calculator.Calculate(43, 5));
            Assert.AreEqual(143, calculator.Calculate(13, 11));
            Assert.AreEqual(250, calculator.Calculate(25, 10));
        }
    }
}