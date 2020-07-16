using System;

namespace Calculator.OneArgClasses
{
    public class FactCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            if (FirstNumber == 0)
                return 1;
            else
                return FirstNumber * Calculate(FirstNumber - 1);
        }
    }
}
