using System;
using System.Windows.Forms;

namespace Calculator.TwoArgsClasses
{
    public class DivisionCalculator : ITwoArgCalculator
    {
        public double Calculate(double FirstNumber, double SecondNumber)
        {
            try
            {
               if (SecondNumber == 0)
                    throw new Exception("DivideByZeroException");
                return (FirstNumber / SecondNumber);
                
            }
            catch (Exception)
            {
                
                return (Double.NaN);
                
            }
        }
    }
}
