// Задайте масив состоящий из вещественых чисел
// найди разницу максимального и минимального элемента масива

double[] CteateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double [size]; 
    Random rnd = new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =  rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

    void PrintArray (double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if(i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}

double MaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length - 1; i++)
    {
        if (max > arr[i]) max = arr[i];
    }
    return max;
}

double MinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length - 1; i++)
    {
        if (min < arr[i]) min = arr[i];
    }
    return min;
}

double[] array = CteateArrayRndInt (5, 1, 10);
double max = MaxElement(array);
double min = MinElement(array);
double result = max - min;
PrintArray(array);
Console.Write(" -> ");
Console.Write ($"{Math.Round(result, 1)}");
