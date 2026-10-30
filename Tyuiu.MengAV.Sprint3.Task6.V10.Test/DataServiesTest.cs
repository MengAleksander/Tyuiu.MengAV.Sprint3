using Tyuiu.MengAV.Sprint3.Task6.V10.Lib;

namespace Tyuiu.MengAV.Sprint3.Task6.V10.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void ForRange20To32()
        {
            int result = ds.GetSumTheDivisors(20, 32);

            Assert.Equal(396, result);
        }

        [Fact]
        public void ReturnsZero()
        {
            int result = ds.GetSumTheDivisors(1, 12);

            Assert.Equal(0, result);
        }
    }
}