// Задай массив заполненый случайными числами.
// Напиши программу, которая показывает сумму чисел стоящих на нечетных позициях.

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


int SummaNotEventNumber(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += arr[i];
        }
    }
    return sum;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}


int[] array = CteateArrayRndInt(10, 1, 10);
int summaNotEventNumber = SummaNotEventNumber(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write("-> ");
Console.WriteLine($"{summaNotEventNumber}");
