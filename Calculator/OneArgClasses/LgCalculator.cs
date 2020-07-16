using System;

namespace Calculator.OneArgClasses
{
    public class LgCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (Math.Log10(FirstNumber));
        }
    }
}
