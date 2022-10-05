int enterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите целое трехзначное число: ");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number > 99 && number < 1000)
            {
                return number;
            }

        }
        Console.WriteLine("Введено неправильное число");
    }
}
Console.Clear();
int userNumber = enterNumber();
Console.WriteLine($"{userNumber} -> {(userNumber % 100) / 10}");