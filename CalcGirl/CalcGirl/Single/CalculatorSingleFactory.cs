using System;

namespace CalcGirl
{
    public static class CalculatorSingleFactory
    {
        public static ISingleCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "sin": 
                    return new Sin();
                case "cos": 
                    return new  Cos();
                case "sqrt": 
                    return new Sqrt();
                case "tan":
                    return new Tan();


                default: throw new ArgumentException("Упс, неизвестная операция...", "name");

            }
        }
    }
}