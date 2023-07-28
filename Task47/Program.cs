﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix, int round = 1)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            double num = Math.Round(matrix[i,j], round);
            Console.Write($"{num,10} ");
        }
        Console.WriteLine("|");
    }
}

double[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);