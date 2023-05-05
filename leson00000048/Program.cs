﻿// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] array2D = CteateMatrixRndInt(3, 4);
PrintMatrix(array2D);




int[,] CteateMatrixRndInt(int rows, int columns)
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