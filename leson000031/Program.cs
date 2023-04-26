// задать масив из 12 элементов
// запоненых случайными числами в промежутке -9 9
// найти сумму положительных и отрицательных элементов массива

int[] CteateArrayRndInt(int size,int min, int max)
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

int SumPositiveElements (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}


int SumNegativeElements (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CteateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
int sumPositiveElements = SumPositiveElements(array);
int sumNegativeElements = SumNegativeElements (array);
Console.WriteLine($"суммa положительных элементов = {sumPositiveElements}");
Console.WriteLine($"сумма отрицательных элементов {sumNegativeElements}");