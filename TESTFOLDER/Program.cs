// Задача 13
Console.Clear();
Console.Write($"Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a < 100) Console.Write("Третьей цифры нет");
else
{
    while (a > 1000)
    {
        a = (int)(a / 10);
    }
    Console.WriteLine(a % 10);
}


// Задача 10
// Console.Clear();
// Console.Write($"Введите число: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write(a%100/10);