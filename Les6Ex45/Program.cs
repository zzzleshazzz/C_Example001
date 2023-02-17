int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] CoppyArray(int[] mas)
{
    int[] CoppyArr = new int[mas.Length];
    for(int i = 0; i<mas.Length; i++) CoppyArr[i] = mas[i];
    return CoppyArr;
}

int[] Array = GetArray(6, 10, 99);
Console.WriteLine($"Оригинал (Array): {string.Join(", ", Array)}");
int[] CoppyArr = CoppyArray(Array);
Console.WriteLine($"Копия (CoppyArr): {string.Join(", ", Array)}");