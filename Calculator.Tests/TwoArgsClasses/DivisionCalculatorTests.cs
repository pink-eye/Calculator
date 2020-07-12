using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            DivisionCalculator calculator = new DivisionCalculator();
            Assert.AreEqual(5, calculator.Calculate(51, 17));
            Assert.AreEqual(1, calculator.Calculate(3, 3));
            Assert.AreEqual(2, calculator.Calculate(40, 20));
        }
    }
}