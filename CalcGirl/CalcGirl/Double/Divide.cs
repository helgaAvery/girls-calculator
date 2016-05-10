namespace CalcGirl.Double
{
   public class Divide: ICalculator
    {
        /// <summary>
        /// Функция делания
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {

            return first / second;
        }
    }
}
