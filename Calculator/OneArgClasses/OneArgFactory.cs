namespace Calculator.OneArgClasses
{
  public static class OneArgFactory
    {
        public static IOneArgCalculator CreateCalculator(string oper)
        {
            switch (oper)
            {
                case ("exp"): return new ExpCalculator();                
    }
            return null;
        }
    }
}
