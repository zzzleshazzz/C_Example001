// Создание и заполнение массива
double[] GetArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }
    return result;
}

void Max_Min(double[] mas)
{
    double max = mas[0];
    double min = mas[0];
    for(int i = 1; i<mas.Length; i++)
    {
        if(max<mas[i]) max = mas[i];
        if(min>mas[i]) min = mas[i];
    }
    Console.Write($"Разница между MAX и MIN = {max-min}");
}


double[] array = GetArray(4);
Console.WriteLine($"[{string.Join(", ", array)}]");
Max_Min(array);
