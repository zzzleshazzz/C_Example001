// Практика. Задача 5
void FillMas(int[] array, int num)
{
    num = -num;
    int i = 0;
    while (i < array.Length)
    {
        array[i] = num;
        i++;
        num++;
    }
}
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int[] mas = new int[a * 2 + 1];
FillMas(mas, a);

int count = 0;
while (count < mas.Length)
    {
        Console.Write($"{mas[count]} ");
        count++;
    }