using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MengAV.Sprint3.Task7.V16.Lib
{
    public class DataServies : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (stopValue < startValue)
                throw new ArgumentException("Конечное значение должно быть не меньше начального.");

            int array = stopValue - startValue + 1;
            double[] values = new double[array];

            for (int i = 0; i < array; i++)
            {
                double x = startValue + i;
                double denominator = x - 0.4;
                double result;

                if (denominator == 0) result = 0;
                else
                {
                    result = Math.Cos(x) / denominator + Math.Sin(x) * 8 * x + 2;
                }

                values[i] = Math.Round(result, 3);
            }

            return values;
        }
    }
}
