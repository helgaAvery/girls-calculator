using System;

namespace CalcGirl.Double
{
   public static class CalculatorFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "add": 
                    return new Add(); 
                case "minus": 
                    return new Minus(); 
                case "multyply": 
                    return new Multyply(); 
                case "divide": 
                    return new Divide();
                case "XinY": 
                    return new XinY();
                case "Log":
                    return new Log();
                case "SqrtY":
                    return new SqrtY();
                case "Ost":
                    return new Ost();

                default: throw new ArgumentException("Упс, неизвестная операция...", "name");

            }
        }
      
    }
}
