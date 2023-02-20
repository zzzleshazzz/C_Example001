int[,] GetArray2D(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 9);
        }
    }
    return result;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumIJ(int[,] array2D)
{
    int min;
    if (array2D.GetLength(0)< array2D.GetLength(1)) min = array2D.GetLength(0);
    else  min = array2D.GetLength(1);
    int sumIJ = 0;
    for (int i = 0; i < min; i++)
    {
        sumIJ+=array2D[i,i];
    }
    return sumIJ;
}

int m = new Random().Next(3, 5);
int n = new Random().Next(3, 5);

int[,] mas = GetArray2D(m, n);
Console.Write("Первоначальный массив:\n");
PrintArray2D(mas);
Console.Write($"Сумма основной диогонали: {SumIJ(mas)}");
