using Tyuiu.MengAV.Sprint3.Task1.V24.Lib;

namespace Tyuiu.MengAV.Sprint3.Task1.V24.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void ForX5()
        {
            double result = ds.GetSumSeries(5, 1, 12);

            Assert.Equal(0.186, result, precision: 3);
        }

        [Fact]
        public void ForX0()
        {
            double result = ds.GetSumSeries(0, 1, 12);

            Assert.Equal(0.5, result, precision: 3);
        }
    }
}