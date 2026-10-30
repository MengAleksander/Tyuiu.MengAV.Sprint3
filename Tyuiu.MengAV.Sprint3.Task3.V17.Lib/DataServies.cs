using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MengAV.Sprint3.Task3.V17.Lib
{
    public class DataServies : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string digits = "";

            foreach (char character in value)
            {
                if (char.IsDigit(character))
                {
                    digits += character;
                }
            }
            return int.Parse(digits.ToString());
        }
    }
}
