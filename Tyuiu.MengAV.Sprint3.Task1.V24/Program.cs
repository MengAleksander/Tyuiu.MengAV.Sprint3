using Tyuiu.MengAV.Sprint3.Task1.V24.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "1"},
{"{{HV}}", "24"},
{"{{TY}}", "Написать программу используя цикл while, которая вычисляет сумму ряда по формуле, при х=5"},
{"{{TV}}", "S = Σ(i=1 to 12) (2 / (6 + x^i))  x=5"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

double sum = ds.GetSumSeries(5, 1, 12);

Console.WriteLine($"Сумма ряда: {sum:F3}");