// программа которая выводит массив из 8 элементов
// заполненные нулями и единичами в случайном порядке
// int[] arr = {2, 5, 6, 2, 4};


// int[] array = new int [8];
// array[0] = 34;
// int size = array.Length;


Console.WriteLine("Ведите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [size];

int[] array = CreateArr(size);
PrintArray(array);


int[] CreateArr(int siz)
{
    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 2);
    }
    return arr;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}