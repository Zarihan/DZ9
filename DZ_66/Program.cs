//Задача 66
using System;

class Program
{
static void Main()
{
int m = 1;
int n = 15;
int sum = SumFromMToN(m, n);
Console.WriteLine("Сумма натуральных элементов от M до N: " + sum);
}
static int SumFromMToN(int m, int n)
{
if (m == n)
{
return m;
}
else
{
return m + SumFromMToN(m + 1, n);
}
}
}