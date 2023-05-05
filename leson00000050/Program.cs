// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента массива, строку");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента массива, столбец");
int colums = Convert.ToInt32(Console.ReadLine());



int[,] array2D = CteateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);
ArrayElements(rows, colums, array2D);


void ArrayElements(int rows, int coulum, int[,] array2D)
{
    if (rows > array2D.GetLength(0) || coulum > array2D.GetLength(1))
    { 
        Console.WriteLine("такого числа нет");
    }
    else 
    {
        Console.WriteLine($"{array2D[rows, coulum]}");
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