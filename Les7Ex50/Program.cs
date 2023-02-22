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
int m = new Random().Next(3,5), n = new Random().Next(3,5);
int[,] array2D = NewRandomArray(m, n);
PrintArray2D(array2D);

Console.Write("Введите позиции элемента через пробел: \n");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

if (array2D.GetLength(0) >= position[0] &&
    array2D.GetLength(1) >= position[1]) Console.Write($"{array2D[position[0], position[1]]}");
else Console.Write("Такого элемента в массиве нет");