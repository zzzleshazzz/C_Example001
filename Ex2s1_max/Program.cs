int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int a1 = 34;
int b1 = 23;
int c1 = 54;
int a2 = 53;
int b2 = 12;
int c2 = 56;
int a3 = 12;
int b3 = 21;
int c3 = 11;

int Max1 = Max(a1, b1, c1);
int Max2 = Max(a2, b2, c2);
int Max3 = Max(a3, b3, c3);

Console.WriteLine(Max(Max1, Max2, Max3));
