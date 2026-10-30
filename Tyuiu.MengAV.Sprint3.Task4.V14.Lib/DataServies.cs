using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MengAV.Sprint3.Task4.V14.Lib
{
    public class DataServies : ISprint3Task4V14
    {
        public double Calculate(int startValue, int stopValue)
        {
            if (stopValue < startValue)
                throw new ArgumentException("Конечное значение должно быть не меньше начального.");

            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) break;

                sum += Math.Cos(x) / Math.Sin(x);
            }

            return sum;
        }
    }
}
