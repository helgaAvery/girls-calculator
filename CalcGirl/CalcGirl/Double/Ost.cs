namespace CalcGirl.Double
{
    public class Ost : ICalculator
    {
        /// <summary>
        /// Функция выполняющая поиск остатка от деления
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}