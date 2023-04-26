// Пользователь вводит М чисел
// сколько чисел ввел больше 0

Console.WriteLine ("Введите количество чисел");
int number = Convert.ToInt32(Console.ReadLine());

int[] newArray = NewArray(number);
Console.WriteLine(" ");
PrintArray(newArray);
int countMoreZero = CountMoreZero(newArray);
Console.Write($" -> {countMoreZero}");

int[] NewArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine ("Введите чисеo");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountMoreZero (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}


void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}
