string ConvertDecToBin(int num)
{
    string result = String.Empty;
    while (num != 0)
    {
        result = (num % 2).ToString() + result;
        num /= 2;
    }
    return result;
}

Console.Write("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Двоичный формат: {ConvertDecToBin(number)}");
