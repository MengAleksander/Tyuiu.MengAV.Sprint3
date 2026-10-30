using Tyuiu.MengAV.Sprint3.Task5.V15.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "5"},
{"{{HV}}", "15"},
{"{{TY}}", "y = Σ(i=1 to 3) Σ(k=1 to 10) (sin(x) + k^2/2)"},
{"{{TV}}", "Х=5"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

double sum = ds.GetSumSumSeries(5, 1, 1, 3, 10);

Console.WriteLine($"Сумма ряда: {sum:F3}");