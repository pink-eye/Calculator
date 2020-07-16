namespace Calculator.OneArgClasses
{
  public static class OneArgFactory
    {
        public static IOneArgCalculator CreateCalculator(string oper)
        {
            switch (oper)
            {
                case ("exp"): return new ExpCalculator();
                case ("sqrt"): return new SqrtCalculator();
                case ("sin"): return new SinCalculator();
                case ("cos"): return new CosCalculator();
                case ("tg"): return new TgCalculator();
                case ("lg"): return new LgCalculator();
                case ("ln"): return new LnCalculator();                
                case ("ctg"): return new CtgCalculator();
                case ("fact"): return new FactCalculator();
            }
            return null;
        }
    }
}
