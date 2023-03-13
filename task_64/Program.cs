/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
using System;
using static System.Console;

string PrintRowNumbers(int m, int n)
{
    if (n == m)
    {
        Write($"{m}");
    }
    else Write($"{PrintRowNumbers(m + 1, n)}, {m}");
    return string.Empty;
}


Clear();
WriteLine("Введите число:");
int n = int.Parse(ReadLine());
int m = 1;
Write($"N = {n} -> ");
string row = PrintRowNumbers(m, n);


