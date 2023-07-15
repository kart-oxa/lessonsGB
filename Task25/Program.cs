// Задача 25: (branch task_1)
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB <= 0)
{
Console.WriteLine("Некорректный ввод!");
return;
}

int degreeNumbers = DegreeNumbers(numberA, numberB);
Console.WriteLine($"Число {numberA} в натуральной степени числа {numberB} = {degreeNumbers}");

int DegreeNumbers(int a, int b)
{
    int deg = 1;
    for (int i = 1; i <= b; i++)
    {
        deg = deg * a;
    }
    return deg;
}