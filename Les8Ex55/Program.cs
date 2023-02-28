int[,] GetArray2D(int row, int col)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray2D(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Transporant(int[,] mas)
{
    int[,] result = new int[mas.GetLength(1), mas.GetLength(0)];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            result[j, i] = mas[i, j];
        }
    }
    return result;
}

int n = new Random().Next(3, 5);
int m = new Random().Next(3, 5);

int[,] Array2D = GetArray2D(n, m);
Console.WriteLine("Original mas:");
PrintArray2D(Array2D);
Console.WriteLine("Result mas:");
int[,] TransporantArray = Transporant(Array2D);
PrintArray2D(TransporantArray);