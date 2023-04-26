// Задай массив заполненый случайными положительными трехзгачными мислами.
// Напиши программу, которая показывает количество четных чисел в массиве.

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


int CountEventNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}


int[] array = CteateArrayRndInt(5, 100, 999);
int countEventNumber = CountEventNumber(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write("-> ");
Console.WriteLine($"{countEventNumber}");
