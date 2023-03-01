int Akerman(int m, int n)
{
    if(m==0) return n+1;
    if(n==0) return Akerman(m-1,1);
    return Akerman(m-1, Akerman(m,n-1));
}

Console.Write("Введите M: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine(Akerman(x, y));