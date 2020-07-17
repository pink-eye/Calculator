namespace Calculator.TwoArgsClasses
{
    public class ProcCalculator : ITwoArgCalculator
    {
        public double Calculate(double FirstNumber, double SecondNumber)
        {
            return (FirstNumber*SecondNumber/100);
        }
    }
}
