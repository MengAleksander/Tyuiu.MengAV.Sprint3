using Tyuiu.MengAV.Sprint3.Task2.V11.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "2"},
{"{{HV}}", "11"},
{"{{TY}}", "Написать программу используя цикл do...while, которая вычисляет сумму ряда по формуле, при х=0,5"},
{"{{TV}}", "S = Σ(i=1 to 15) (1 / (3 + x^i))^i  x=0,5"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

double sum = ds.GetSumSeries(0.5, 1, 15);

Console.WriteLine($"Сумма ряда: {sum:F3}");