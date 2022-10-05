string enterNumberStr()
{
    string numberStr;
    while (true)
    {
        Console.Write("Введите целое число: ");
        numberStr = Console.ReadLine() ?? "";
        if (int.TryParse(numberStr, out int a2))
        {
            return numberStr;
        }
        Console.WriteLine("Ввод неверный");
    }
}
Console.Clear();
string str = enterNumberStr();
if (str.Length > 2)
{
    Console.WriteLine($"{str} -> {str[2]}");
}
else
{
    Console.WriteLine($"{str} -> третьей цифры нет");
}
