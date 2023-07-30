﻿// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigits(int num)
{
if (num == 0) return 0;
return num % 10 + SumDigits(num / 10); //num = 453 / 10 -> 45 / 10 -> 4 /10 -> 0
}

Console.WriteLine(SumDigits(45));

// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(5));