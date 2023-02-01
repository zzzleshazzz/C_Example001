int findex(int[] mas, int find)
{
    int index = 0;
    while(index < mas.Length)
    {
        if (mas[index] == find) break;
        else index++;
    }
    return index;
}

int[] array = { 12, 32, 53, 14, 25, 66, 78, 68, 49 };
int find = 53;

Console.WriteLine(findex(array, find));