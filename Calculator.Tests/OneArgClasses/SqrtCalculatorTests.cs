using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgClasses
{
    [TestFixture]
    public class SqrtCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            SqrtCalculator calculator = new SqrtCalculator();
            Assert.AreEqual(2, calculator.Calculate(4));
        }
    }
}