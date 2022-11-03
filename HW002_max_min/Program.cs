int a = new Random().Next(-100,100);
Console.WriteLine(a);
int b = new Random().Next(-100,100);
Console.WriteLine(b);
int max = a;
int min = a;
if (b > max)
{
    max = b;
}
else
{
    min = b;
}
Console.Write("max  ");
Console.WriteLine(max);
Console.Write("min  ");
Console.WriteLine(min);
