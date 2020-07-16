using System;

namespace Calculator.OneArgClasses
{
    public class CtgCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (Math.Tan(Math.PI / 2 - (FirstNumber * Math.PI / 180.0)));
        }
    }
}
