// Найди произведение пар чисел в одномерном масиве
// парой считается первый и последний элементоввторой и предпоследний
// результат записать в новом массиве


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

int[] MultiplicatePairArray(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length%2 == 1) size += 1;
    int[] newArr = new int [size];
    
    for (int i = 0; i < arr.Length/2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length -1-i];
    }
    if (arr.Length%2 == 1) newArr[newArr.Length-1] = arr[arr.Length/2];
    return newArr;
}


void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        // double round = Math.Round(arr [i], 1);
        // if(i < arr.Length - 1) Console.Write($"{round}, ");
        // else Console.Write($"{round}");


        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}



int[] array = CteateArrayRndInt(5, 1, 10);
int [] result = MultiplicatePairArray(array);
Console.Write("[");
PrintArray (array);
Console.WriteLine("] -> ");
PrintArray (result);
