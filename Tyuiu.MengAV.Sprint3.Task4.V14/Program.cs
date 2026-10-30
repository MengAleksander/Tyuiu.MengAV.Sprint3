using Tyuiu.MengAV.Sprint3.Task4.V14.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "4"},
{"{{HV}}", "14"},
{"{{TY}}", "На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=cos(x)/sin(x)"},
{"{{TV}}", "x принимает значения от -5 до 5"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

double sum = ds.Calculate(-5, 5);

Console.WriteLine($"Сумма значений функции: {sum:F3}");