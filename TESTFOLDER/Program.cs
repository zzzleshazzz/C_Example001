// Практика. Задача 7
Console.WriteLine("Введите 3х значное число: ");
int a = int.Parse(Console.ReadLine()!);
if (99 < a & a < 1000)
{
    Console.WriteLine(a % 10);
}
else Console.WriteLine("Введите другое число");