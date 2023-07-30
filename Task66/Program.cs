// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (number1 > number2) 
{
    temp = number1;
    number1 = number2;
    number2 = temp;
}
int SumNaturalDigits(int num1, int num2)
{
        if (num2 == num1) return num1;
        return num1 + SumNaturalDigits(num1 + 1, num2);
}

Console.WriteLine(SumNaturalDigits(number1, number2));