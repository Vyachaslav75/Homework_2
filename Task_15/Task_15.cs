int enterNumberWeek()
{
    int number;
    while (true)
    {
        Console.Write("Введите номер дня недели: ");
        if (int.TryParse(Console.ReadLine(), out number) && (number > 0 && number < 8))
        {
            return number;
        }
        Console.WriteLine("Введите число от 1 до 7");
    }
}
Console.Clear();
int dayNumber = enterNumberWeek();
if (dayNumber > 5)
{
    Console.WriteLine($"{dayNumber} -> да");
}
else
{
    Console.WriteLine($"{dayNumber} -> нет");
}
