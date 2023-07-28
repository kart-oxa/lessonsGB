// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

void AvarageIndexElem(int[,] matrix, int round = 1)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avarage = (avarage + matrix[i, j]);
        }
        avarage = avarage / matrix.GetLength(0);
        double num = Math.Round(avarage, round);
        Console.Write(num + "; ");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
AvarageIndexElem(array2d);
Console.WriteLine();
PrintMatrix(array2d);