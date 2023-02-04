Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

// РЕШЕНИЕ ДЛЯ ЧИСЕЛ ЛЮБОЙ ДЛИНЫ

int a = n;
int b = 0;
while (a > 0)
{
    b *= 10;
    b += a % 10;
    a = a / 10;
}
if (n == b) Console.WriteLine("Да");
else Console.WriteLine("Нет");


// РЕШЕНИЕ ТОЛЬКО ДЛЯ 5 ЗНАЧНЫХ ЧИСЕЛ

// if (n / 10000 == n % 10)
// {
//     if (n / 1000 % 10 == n % 100 / 10) Console.WriteLine("Да");
//     else Console.WriteLine("Нет");
// }
// else Console.WriteLine("Нет");

