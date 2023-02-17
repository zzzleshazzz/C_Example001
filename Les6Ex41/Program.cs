Console.Clear();

int[] CreateArray(int n)
{
    int[] newArr = new int[n];
    for(int i = 0; i<n;i++) newArr[i] = int.Parse(Console.ReadLine()!);
    return newArr;
}

int CountPositive(int[] mas)
{
    int result = 0;
    for(int i = 0; i<mas.Length; i++) if(mas[i]>0) result++;
    return result;
}

Console.Write("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числа, каждое с новой строки: ");
int[] array = CreateArray(M);
Console.Write($"Количество введенных чисел > 0 = {CountPositive(array)}");