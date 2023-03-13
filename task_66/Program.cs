/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
using System;
using static System.Console;

int SumNumbers(int m, int n)
{
    int sum = 0;
    if (n == m)
    {
        sum = m;
    }
    else sum = n + SumNumbers(m, n - 1);
    return sum;
}

Clear();
WriteLine("Введите число M:");
int m = int.Parse(ReadLine());
WriteLine("Введите число N:");
int n = int.Parse(ReadLine());
Write ($"M = {m}; N = {n} -> {SumNumbers(m, n)}");


