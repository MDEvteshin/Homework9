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

void FindNum (int m, int n)
{
    if ( m != n)
    {
        if (m<n)
        {
            FindNum(m, n - 1);
            System.Console.Write(n + " ");
        }
        else 
        {
            System.Console.Write(m + " ");
            FindNum(m-1, n);
        }
    }
    else System.Console.Write(n + " ");
}
FindNum(10, 2); 