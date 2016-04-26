namespace CalcGirl.Double
{
    public class Percent : ICalculator
    {
        /// <summary>
        /// Функция нахождения процента от числа
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first * second / 100;
        }
    }
}