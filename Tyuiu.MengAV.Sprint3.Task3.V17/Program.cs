using Tyuiu.MengAV.Sprint3.Task3.V17.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../Cap.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "3"},
{"{{HV}}", "17"},
{"{{TY}}", "Используя цикл foreach удалить все буквы и знаки препинания, оставить цифру затем преобразовать в число в строке"},
{"{{TV}}", "*vn98n! b,"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

int number = ds.ConvertStringToInt("*vn98n! b,");

Console.WriteLine($"Полученное число: {number}");