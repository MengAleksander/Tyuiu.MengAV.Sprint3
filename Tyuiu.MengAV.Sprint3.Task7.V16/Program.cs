using Tyuiu.MengAV.Sprint3.Task7.V16.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "6"},
{"{{HV}}", "10"},
{"{{TY}}", "Написать программу, которая выводит таблицу значений функции:\nF(x) = cos(x) / (x - 0,4) + sin(x) * 8x + 2"},
{"{{TV}}", "[-5; 5] с шагом 1"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

int startValue = -5;
int stopValue = 5;
double[] values = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("   x | F(x)");
Console.WriteLine("------------");

for (int i = 0; i < values.Length; i++)
{
    int x = startValue + i;
    Console.WriteLine($"{x,4} | {values[i],6:F3}");
}