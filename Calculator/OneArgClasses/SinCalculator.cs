using System;

namespace Calculator.OneArgClasses
{
    public class SinCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (Math.Sin(FirstNumber * Math.PI / 180.0));
        }
    }
}
