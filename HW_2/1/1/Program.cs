int a = 1;
int b = 3;
int c = 6;
int d = 2;
int e = 9;

int max = a;


if (max < a)  max = a;
if (max < b)  max = b;
if (max < c)  max = c;
if (max < d)  max = d;
if (max < e)  max = e;

Console.Write("max = ");
Console.Write(max);