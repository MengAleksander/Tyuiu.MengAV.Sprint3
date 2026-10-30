using Tyuiu.MengAV.Sprint3.Task0.V11.Lib;

namespace Tyuiu.MengAV.Sprint3.Task0.V11.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void ForOneTerm()
        {
            Assert.Equal(0.04, ds.GetSumSeries(5, 1, 1), 3);
        }

        [Fact]
        public void ForTwoTerms()
        {
            Assert.Equal(0.042, ds.GetSumSeries(5, 1, 2), 3);
        }

        [Fact]
        public void ForTenTerms()
        {
            Assert.Equal(0.042, ds.GetSumSeries(5, 1, 10), 3);
        }
    }
}