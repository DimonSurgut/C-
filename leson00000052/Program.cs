﻿// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array2D = CteateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);
Console.Write("Среднее арифметическое каждого столбца:  ");
ArithmeticMean(array2D);




void ArithmeticMean (int[,] arr)
{
    double sum = 0; 
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
          sum += arr[i, j];
        }
        Console.Write($"{ sum / arr.GetLength(0)},  ");
    }
}


int[,] CteateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int [rows, columns]; 
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          matrix[i, j] = rnd.Next(min, max + 1);   
        }
        
    }
    return matrix;
}


void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          Console.Write($"{matrix[i, j], 5} ");
        }
    Console.WriteLine("|");
    }
}