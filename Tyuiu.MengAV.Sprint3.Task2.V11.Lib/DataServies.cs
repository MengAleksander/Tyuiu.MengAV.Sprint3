using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MengAV.Sprint3.Task2.V11.Lib
{
    public class DataServies : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;

            do
            {
                sum += Math.Pow(1.0 / (3 + Math.Pow(value, i)), i);
                i++;
            }
            while (i <= stopValue);

            return sum;
        }
    }
}
