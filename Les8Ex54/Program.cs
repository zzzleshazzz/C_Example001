int[,] NewRandomArray(int row, int col)
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

void SortedRow(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        bool res = true;
        int elem;
        while(res)
        {
            res = false;
            for (int j = 1; j < mas.GetLength(1); j++)
            {
                if(mas[i,j]>mas[i,j-1]) 
                {
                    elem = mas[i,j-1];
                    mas[i,j-1] = mas[i,j];
                    mas[i,j] = elem;
                    res = true;
                }
            }
        }
    }
}

int m = new Random().Next(3,5), n = new Random().Next(3,5);
int[,] array2D = NewRandomArray(m, n);
Console.WriteLine("Первоначальный массив:");
PrintArray2D(array2D);
Console.WriteLine();
Console.WriteLine("Упорядоченный массив:");
SortedRow(array2D);
PrintArray2D(array2D);