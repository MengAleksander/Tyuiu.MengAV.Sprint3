using Tyuiu.MengAV.Sprint3.Task7.V16.Lib;

namespace Tyuiu.MengAV.Sprint3.Task7.V16.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void ForRange5To5()
        {
            double[] result = ds.GetMassFunction(-5, 5);

            Assert.Equal(11, result.Length);
        }

        [Fact]
        public void ForX0()
        {
            double[] result = ds.GetMassFunction(0, 0);

            Assert.Equal(-0.5, result[0], precision: 3);
        }

        [Fact]
        public void ThrowsException()
        {
            Assert.Throws<ArgumentException>(
                () => ds.GetMassFunction(5, -5));
        }
    }
}