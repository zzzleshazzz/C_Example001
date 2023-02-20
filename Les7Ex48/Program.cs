int[,] GetArray2D(int m,int n)
{
    int[,] result = new int[m,n];
    for(int i = 0; i<result.GetLength(0);i++)
    {
        for(int j = 0; j<result.GetLength(1);j++)
        {
            result[i,j] = i+j;
        }
    }
    return result;
}

void PrintArray2D(int[,] array2D)
{
    for(int i = 0; i<array2D.GetLength(0);i++)
    {
        for(int j = 0; j<array2D.GetLength(1);j++)
        {
            Console.Write($"{array2D[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол. строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол. столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] mas = GetArray2D(m,n);
PrintArray2D(mas);