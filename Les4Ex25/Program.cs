int Powe(int A, int B)
{
    int result = 1;
    for (int i = 0; i<B; i++)
    {
        result*=A;
    }
    return result;
}

Console.Write($"Введите A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Введите B: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{a}^{b} = {Powe(a,b)}");