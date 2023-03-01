int SumNtoM(int m, int n)
{
    if (m==n) return m;
    return SumNtoM(m+1,n)+m;
}

Console.Write("Введите M: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNtoM(x, y));