using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            AdditionCalculator calculator = new AdditionCalculator();
            Assert.AreEqual(12, calculator.Calculate(7, 5));
            Assert.AreEqual(30, calculator.Calculate(15, 15));
            Assert.AreEqual(21, calculator.Calculate(10.6, 10.4));
        }
    }
}
