using System;

namespace Calculator.TwoArgsClasses
{
    public class PowCalculator : ITwoArgCalculator
    {
        public double Calculate(double FirstNumber, double SecondNumber)
        {
            return (Math.Pow(FirstNumber, SecondNumber));
        }
    }
}
