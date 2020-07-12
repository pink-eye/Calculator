using System;
using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class PowCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            PowCalculator calculator = new PowCalculator();
            Assert.AreEqual(1, calculator.Calculate(5, 0));
            Assert.AreEqual(2, calculator.Calculate(5, 2));
            Assert.AreEqual(27, calculator.Calculate(3, 3));
        }
    }
}