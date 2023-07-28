// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
// 0 1
int[,] matrix = new int[rows, columns]; // 3 x 4

Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
{
for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
{
matrix[i, j] = rnd.Next(min, max + 1);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
{
Console.Write($"{matrix[i, j], 5} ");
}
Console.WriteLine("|");
}
}

Console.WriteLine("Укажите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);

if (n > array2d.GetLength(0) || m > array2d.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
if ( n <= 0 || m <= 0) 
{
    Console.WriteLine ("Введите корректную позицию элемета");
}
else
{
    Console.WriteLine($"Указанная позиция элемента равна {array2d[n-1,m-1]}");
}
PrintMatrix(array2d);