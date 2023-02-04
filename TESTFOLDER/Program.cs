Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
int i=1;
while(i<=n)
{
    Console.Write($"{i*i}");
    if(i<n) Console.Write(", ");
    i++;
}