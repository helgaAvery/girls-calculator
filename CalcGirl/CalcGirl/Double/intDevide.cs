namespace CalcGirl.Double
{
    public class IntDevide : ICalculator
    {
        /// <summary>
        /// Функция целочисленного деления
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return (int) (first/second);
        }
    }
}