// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Ведите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [size];

int[] array = CreateArr(size);
PrintArray(array);
Console.Write("-> ");
Console.Write("{");
PrintArray(array);
Console.Write("}");


int[] CreateArr(int siz)
{
    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 100);
    }
    return arr;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
}