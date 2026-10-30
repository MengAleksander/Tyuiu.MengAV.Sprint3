using Tyuiu.MengAV.Sprint3.Task6.V10.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "6"},
{"{{HV}}", "10"},
{"{{TY}}", "Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [20, 32] сумму всех делителей больше 12"},
{"{{TV}}", "[20, 32]"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

int sum = ds.GetSumTheDivisors(20, 32);

Console.WriteLine($"Сумма делителей больше 12: {sum}");