// задай одномерный масив из 123 случайных чисел 
// найди количество элементов массива значение которых лежат в отрезке [10,99]

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

int FindCount (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] < 100) 
        count ++;
    }
    return count;
}

int[] array = CteateArrayRndInt(123, -20, 200);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();

int resultCount = FindCount (array);
Console.WriteLine(resultCount);
