double[,] NewRandomArray(int row, int col)
{
    double[,] result = new double[row, col];
    for(int i = 0; i< row; i++)
    {
        for(int j = 0; j< col; j++)
        {
            result[i,j] = Math.Round(new Random().NextDouble() *10, 1);
        }
    }
    return result;
}

void PrintArray2D(double[,] array2D)
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

int m = new Random().Next(3, 5);
int n = new Random().Next(3, 5);

double[,] array2D = NewRandomArray(m, n);
PrintArray2D(array2D);