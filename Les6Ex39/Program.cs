int[] NewArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(minValue, maxValue);
    return array;
}

void ReverseArray(int[] mas)
{
    int len = mas.Length;
    for (int i = 0; i < len / 2; i++)
    {
        int a = mas[i];
        mas[i] = mas[len-i-1];
        mas[len-i-1] = a;
    }
}

int[] arr = NewArray(4, 1, 5);
Console.WriteLine(string.Join(", ", arr));
ReverseArray(arr);
Console.WriteLine(string.Join(", ", arr));
