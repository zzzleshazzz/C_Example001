Console.Clear();
int xa = 40, ya = 1,
    xb = 1, yb = 20,
    xc = 80, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x=0, y=0;
int count = 0;
while (count < 20000)
{
    int i = new Random().Next(0, 3);
    if (i == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if (i == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if (i == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    count++;
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
};