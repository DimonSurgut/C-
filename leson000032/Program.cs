// Напиши программу замена элементов массива
// Заменить положительные элементы на соответствующие отрицательные и наоборот

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

void TransformArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] array = CteateArrayRndInt(4, -9, 9);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
TransformArray(array);
PrintArray(array);