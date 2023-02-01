int fmax(int[] mas)
{
    int result = mas[0];
    int i = 0;
    while (i < mas.Length)
    {
        if (result < mas[i]) result = mas[i];
        i++;
    }
    return result;
}

int[] list = { 9, 8, 7, 6, 5, 44, 3, 10, 11, 12, 22, 11 };

Console.WriteLine(fmax(list));