Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n / 10000 == n % 10)
{
    if (n / 1000 % 10 == n % 100 / 10) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Нет");