using Tyuiu.MengAV.Sprint3.Task2.V11.Lib;

namespace Tyuiu.MengAV.Sprint3.Task2.V11.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void ForX05()
        {
            double result = ds.GetSumSeries(0.5, 1, 15);

            Assert.True(result > 1.0 / 3.5);
            Assert.True(result < 1.0);
        }

        [Fact]
        public void ForOneTerm()
        {
            double result = ds.GetSumSeries(0.5, 1, 1);

            Assert.Equal(1.0 / 3.5, result, precision: 3);
        }

    }
}