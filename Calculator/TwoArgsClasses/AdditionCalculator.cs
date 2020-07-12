namespace Calculator.TwoArgsClasses
{
    public class AdditionCalculator : ITwoArgCalculator
    {
        public double Calculate(double FirstNumber, double SecondNumber)
        {
            return (FirstNumber + SecondNumber);
        }
    }
}
