// напиши программу которая перевернет одномерный массив

int[] CteateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size]; 
    Random rnd = new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1); 
        // arr[i] =  rnd.Next.Double() * (max - min) + min;
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


void ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int tamp = arr[i];
        arr [i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}


int[] array = CteateArrayRndInt(5, 1, 9);
PrintArray (array);
Console.Write();
ReverseArray(array);
PrintArray(array);
