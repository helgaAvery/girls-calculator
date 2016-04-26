namespace CalcGirl.Double
{
    class Minus: ICalculator
    {
        /// <summary>
        /// Функция вычитания
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
