using System;

namespace Calculator.OneArgClasses
{
    public class CosCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (Math.Cos(FirstNumber * Math.PI / 180.0));
        }
    }
}
