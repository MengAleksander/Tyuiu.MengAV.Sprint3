using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MengAV.Sprint3.Task0.V11.Lib
{
    public class DataServies : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
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
