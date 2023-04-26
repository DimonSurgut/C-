// Задайте массива
// Напишите програма которая определяет соответствует ли число задагому масиву

int[] CteateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size]; 
    Random rnd = new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}


bool FindDigit(int [] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) return true;
    }
    return false;
}


Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());


int[] array = CteateArrayRndInt(4, -9, 9);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
bool findDigi = FindDigit(array, number);
Console.WriteLine();
Console.WriteLine(findDigi ? "да" : "нет");