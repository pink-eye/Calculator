namespace Calculator.TwoArgsClasses
{
    public class SubtractionCalculator : ITwoArgCalculator
    {
        public double Calculate(double FirstNumber, double SecondNumber)
        {
            return (FirstNumber - SecondNumber);
        }
    }
}
