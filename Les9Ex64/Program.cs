string NaturalNum(int n)
{
    if (n==1) return $"{1}";
    return $"{n}, "+NaturalNum(n-1);
}

Console.Write("Введите N: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(NaturalNum(num));