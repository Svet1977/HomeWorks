﻿// Напишите программу, котооая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// Например, 645 -5, 78 - третьей цифры нет, 32679-6.

Console.Write("Введите число  ");
int n=Convert.ToInt32(Console.ReadLine());
if(n<0) n=-n;
while(n>1000) n=n/10;
if (n<100) Console.Write("третьей цифры нет  ");
    else
    {
        Console.Write("Третья цифра введенного числа -  ");
        Console.WriteLine(n%10); 
    }
        