using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MengAV.Sprint3.Task6.V10.Lib
{
    public class DataServies : ISprint3Task6V10
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            for (int number = startValue; number <= stopValue; number++)
            {
                for (int divisor = 13; divisor <= number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        sum += divisor;
                    }
                }
            }

            return sum;
        }
    }
}
