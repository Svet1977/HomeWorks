// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.

int N = new Random().Next(1, 20);
Console.Write("Выбранный интервал от 1 до ");
Console.WriteLine(N);
int result=0;

for(int b=1;b<=N; b++)
{
    result=b*b*b;
    Console.Write($"{result}  ");
}
