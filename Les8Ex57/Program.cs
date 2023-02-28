int[,] GetArray2D(int row, int col, int minValue = 1, int maxValue = 10)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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

int[] TwoDToOneD(int[,] mas)
{
    int[] result = new int[mas.GetLength(0)*mas.GetLength(1)];
    int c = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            result[c++] = mas[i,j];
        }
    }
    
    return result;
}

void Sort(int[] mas)
{
    int Temp;
    for (int i = 0; i < mas.Length-1; i++)
    {
        for (int j = i+1; j < mas.Length; j++)
        {
            if(mas[i]>mas[j])
            {
                Temp = mas[i];
                mas[i] = mas[j];
                mas[j] = Temp;
            }
        }
    }
}

void CountElements(int[] mas)
{
    int count = 1;
    for (int i = 0; i < mas.Length-1; i++)
    {
        if(mas[i]==mas[i+1]) count++;
        else 
        {
            Console.WriteLine($"Элемент {mas[i]} встречается {count} раз");
            count = 1;
        }
    }
    Console.WriteLine($"Элемент {mas[mas.Length - 1]} встречается {count} раз");
}

int n = new Random().Next(3, 5);
int m = new Random().Next(3, 5);

int[,] Array2D = GetArray2D(n, m);
PrintArray2D(Array2D);
int[] Array1D = TwoDToOneD(Array2D);
Sort(Array1D);
CountElements(Array1D);