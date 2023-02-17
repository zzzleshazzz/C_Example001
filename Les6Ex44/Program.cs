int[] Fibonachi(int num)
{
    int[] mas = new int[num];
    mas[0] = 0;
    mas[1] = 1;
    for(int i = 2; i<num;i++)
    {
        mas[i]= mas[i-1]+mas[i-2];
    }
    return mas;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"{string.Join(", ", Fibonachi(a))}");