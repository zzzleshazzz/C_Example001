int[] Mass(int n)
{
    int[] mas = new int[n];
    for(int i = 0; i<n; i++)
    {
        mas[i] = int.Parse(Console.ReadLine()!); 
    }
    return mas;
}

void PrintMas(int[] masiv)
{
    for(int i = 0; i<masiv.Length; i++)
    {
        Console.Write($"{masiv[i]} ");
    }
}

Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите элементы массива, каждый с новой строчки: ");
PrintMas(Mass(a));