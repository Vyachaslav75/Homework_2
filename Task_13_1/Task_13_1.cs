int enterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine("Введено неправильное число");
    }
}
Console.Clear();
int userNumber = enterNumber();
int tmp = userNumber;
int count = 1;
while (userNumber / 10 != 0)
{
    userNumber = userNumber / 10;
    count = count * 10;
}
if (tmp < 100)
{
    Console.WriteLine($"{tmp} -> нет третьей цифры");
}
else
{
    count = (tmp / (count / 100)) % 10;
    Console.WriteLine($"{tmp} -> {count}");
}