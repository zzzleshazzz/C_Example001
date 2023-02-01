void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(coll[position] + " ");
        position++;
    }
}

int Findex(int[] mas, int find)
{
    int i = 0;
    int pos = -1;
    while (i < mas.Length)
    {
        if (mas[i] == find) 
        {
            pos = i;
            break;
        }
            i++;
    }

    return pos;
}

int[] array = new int[10];
int find = 4;

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(Findex(array, find));
