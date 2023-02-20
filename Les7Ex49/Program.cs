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

void NewArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array2D[i, j] *= array2D[i, j];
        }
    }
}

int m = new Random().Next(3, 5);
int n = new Random().Next(3, 5);

int[,] mas = GetArray2D(m, n);
Console.Write("Первоначальный массив:\n");
PrintArray2D(mas);
NewArray(mas);
Console.Write("Результат:\n");
PrintArray2D(mas);
