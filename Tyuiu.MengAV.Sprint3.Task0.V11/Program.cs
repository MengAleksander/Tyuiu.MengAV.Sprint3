using Tyuiu.MengAV.Sprint3.Task0.V11.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "0"},
{"{{HV}}", "11"},
{"{{TY}}", "Написать программу используя цикл for, которая вычисляет сумму ряда по формуле, при n = 5"},
{"{{TV}}", "S = Σ(k=1 to 10) (1/k)^2  n=5"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

double sum = ds.GetSumSeries(5, 1, 10);

Console.WriteLine($"Сумма ряда: {sum:F3}");