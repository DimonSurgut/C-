﻿// : Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] array2D = CteateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);


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

int Summa(int[,] matrix)
{
    int sum = matrix [0,0];
    for (int count = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
          sum += matrix[i, j];   
        }
        
    }
    return sum;
}