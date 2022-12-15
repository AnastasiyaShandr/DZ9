// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

SumNumber(m, n);

void SumNumber(int m, int n)
{
    Console.Write(Sum(m - 1, n));
}

int Sum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Sum(m, n);
        return res;
    }
}