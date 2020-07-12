using System;
using NUnit.Framework;
using Calculator.TwoArgsClasses;

namespace Calculator.Tests.TwoArgsClasses
{
    [TestFixture]
    public class TwoArgFactoryTests
    {
        [Test]
        [TestCase("pow", typeof(PowCalculator))]
        [TestCase("plus", typeof(AdditionCalculator))]
        [TestCase("minus", typeof(SubtractionCalculator))]
        [TestCase("mult", typeof(MultiplyCalculator))]
        [TestCase("div", typeof(DivisionCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}