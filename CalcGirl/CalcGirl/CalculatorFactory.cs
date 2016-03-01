using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGirl
{
    class CalculatorFactory
    {
        public ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "add": return new Add(); 
                case "minus": return new Minus(); 
                case "multyply": return new Multyply(); 
                case "divide": return new Divide(); 
                default: throw new ArgumentException("Упс, неизвестная операция...", "name");

            }
        }
      
    }
}
