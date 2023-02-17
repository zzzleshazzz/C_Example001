string BornTreug(int q, int w, int e)
{
    if (q < w + e && w < q + e && e < w + q) return "может";
    else return "не может";
}
Console.Write("Введите сторону A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите сторону B: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите сторону C: ");
int c = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Треугольник со сторонами: {a}, {b}, {c} - {BornTreug(a, b, c)} существовать");