using System;

namespace Calculator.OneArgClasses
{
    public class LnCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (Math.Log(FirstNumber));
        }
    }
}
