namespace Calculator.TwoArgsClasses
{
    public class MultiplyCalculator : ITwoArgCalculator
    {
       public double Calculate(double FirstNumber, double SecondNumber)
        {
            return (FirstNumber * SecondNumber);
        }
    }
}
