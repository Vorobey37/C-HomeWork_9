/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
using System;
using static System.Console;

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ackerman(m - 1, 1);
    if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return Ackerman(m, n);
}

Clear();
WriteLine("Введите неотрицательное число M:");
int m = int.Parse(ReadLine());
WriteLine("Введите неотрицательное число N:");
int n = int.Parse(ReadLine());
WriteLine(Ackerman(m, n));