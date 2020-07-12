using System;

namespace Calculator.OneArgClasses
{
    public class ExpCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (Math.Exp(FirstNumber));
        }
    }
}
