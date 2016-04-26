namespace CalcGirl.Double
{
    class Multyply: ICalculator
    {
        /// <summary>
        /// Функция умножения
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
