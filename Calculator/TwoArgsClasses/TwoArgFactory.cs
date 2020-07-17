using Calculator.OneArgClasses;

namespace Calculator.TwoArgsClasses
{
    public static class TwoArgFactory
    {
        public static ITwoArgCalculator CreateCalculator(string oper)
        {
           switch(oper)
            {
                case ("plus"): return new AdditionCalculator();
                case ("minus"): return new SubtractionCalculator();
                case ("mult"): return new MultiplyCalculator();
                case ("div"): return new DivisionCalculator();
                case ("pow"): return new PowCalculator();
                case ("proc"): return new ProcCalculator();
            }
            return null;
        }
    }
}
