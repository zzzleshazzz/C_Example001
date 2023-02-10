Console.Clear();
// Создание и заполнение массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

// Сумма нечетных элементов
int SumOdd(int[] mas)
{
    int sumodd = 0;
    for(int i = 1; i<mas.Length; i+=2)
    {
        sumodd+= mas[i];
    }
    return sumodd;
}

int[] array = GetArray(4, 1, 10);
Console.WriteLine($"Сумма нечетных чисел массива:\n[{string.Join(",", array)}]\nРавна: {SumOdd(array)}");