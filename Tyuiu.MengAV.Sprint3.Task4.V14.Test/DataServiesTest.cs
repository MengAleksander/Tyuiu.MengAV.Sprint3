using Tyuiu.MengAV.Sprint3.Task4.V14.Lib;

namespace Tyuiu.MengAV.Sprint3.Task4.V14.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void ReturnsZero()
        {
            double result = ds.Calculate(0, 5);

            Assert.Equal(0, result);
        }

        [Fact]
        public void ThrowsException()
        {
            Assert.Throws<ArgumentException>(
                () => ds.Calculate(5, -5));
        }
    }
}