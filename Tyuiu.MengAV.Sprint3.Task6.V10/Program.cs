using Tyuiu.MengAV.Sprint3.Task6.V10.Lib;

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

int sum = ds.GetSumTheDivisors(20, 32);

Console.WriteLine($"Сумма делителей больше 12: {sum}");