using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MengAV.Sprint3.Task0.V11.Lib
{
    public class DataServies : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            if (value == 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            if (startValue < 1 || stopValue < startValue)
                throw new ArgumentOutOfRangeException(nameof(startValue));

            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double fraction = 1.0d / Math.Pow(value, k);
                sum += Math.Pow(fraction, 2);
            }

            return sum;
        }
    }
}
