using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MengAV.Sprint3.Task1.V24.Lib
{
    public class DataServies : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;

            while (i <= stopValue)
            {
                sum += Math.Pow(2.0d / (6 + Math.Pow(value, i)), i);
                i++;
            }

            return sum;
        }
    }
}
