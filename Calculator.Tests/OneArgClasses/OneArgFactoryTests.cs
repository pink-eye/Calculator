using System;
using NUnit.Framework;
using Calculator.OneArgClasses;

namespace Calculator.Tests.OneArgsClasses
{
    [TestFixture]
    public class OneArgFactoryTests
    {
        [Test]
        [TestCase("exp", typeof(ExpCalculator))]
        [TestCase("sqrt", typeof(SqrtCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}