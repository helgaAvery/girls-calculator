using System;

namespace CalcGirl
{
    public static class CalculatorSingleFactory
    {
        public static ISingleCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Sin": 
                    return new Sin();
                case "Cos": 
                    return new  Cos();
                case "Sqrt": 
                    return new Sqrt();
                case "Tan":
                    return new Tan();

               default: throw new ArgumentException("Упс, неизвестная операция...", "name");

            }
        }
    }
}