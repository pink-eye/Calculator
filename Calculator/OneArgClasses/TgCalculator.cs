using System;

namespace Calculator.OneArgClasses
{
    public class TgCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (Math.Tan(FirstNumber * Math.PI / 180.0));
        }
    }
}
