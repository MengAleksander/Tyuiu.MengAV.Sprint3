using Tyuiu.MengAV.Sprint3.Task5.V15.Lib;

namespace Tyuiu.MengAV.Sprint3.Task5.V15.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void ForX5AndGivenRanges()
        {
            double result = ds.GetSumSumSeries(5, 1, 1, 3, 10);

            double expected = 3 * (10 * Math.Sin(5) + 385.0 / 2.0);

            Assert.Equal(expected, result, precision: 3);
        }

        [Fact]
        public void ReturnsOneTerm()
        {
            double result = ds.GetSumSumSeries(5, 1, 2, 1, 2);

            double expected = Math.Sin(5) + Math.Pow(2, 2) / 2.0;

            Assert.Equal(expected, result, precision: 3);
        }
    }
}