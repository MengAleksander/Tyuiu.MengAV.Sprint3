using Tyuiu.MengAV.Sprint3.Task3.V17.Lib;

namespace Tyuiu.MengAV.Sprint3.Task3.V17.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void ForGivenString()
        {
            int result = ds.ConvertStringToInt("*vn98n! b,");

            Assert.Equal(98, result);
        }

        [Fact]
        public void WhenStringContainsNoDigits()
        {
            Assert.Throws<FormatException>(
                () => ds.ConvertStringToInt("abc!"));
        }
    }
}