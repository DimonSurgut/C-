// Не используя рекурсию выведите первыйе N чисел Фибоначи.
//  Первый два числа Фибоначи: 0 и 1.

Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int[] result = Fibonachi(number);
PrintArray(result);



int[] Fibonachi(int num)
{
    int[] array = new int[num];
    // array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
       array[i] = array[i - 1] + array[i -2];
    }
    return array;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}
