// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int reverseOrder (int n)
// {
//     if (n >=1)
//     {
//     System.Console.Write(n + " ");
//     reverseOrder (n-1);
//     }
//     return n;
// }

// System.Console.WriteLine("Input number");
// int n = Convert.ToInt32(Console.ReadLine());

// reverseOrder(n); 

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

Console.Write("Input number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(SumMN(m - 1, n));