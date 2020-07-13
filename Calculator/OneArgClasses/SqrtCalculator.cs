using System;

namespace Calculator.OneArgClasses
{
    public class SqrtCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (Math.Sqrt(FirstNumber));
        }
    }
}