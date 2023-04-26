// Напиши программу, которая будет преобразовывать десятичное число в двоичное

Console.WriteLine ("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    int resultBin = DecToDin(number);
    Console.WriteLine(resultBin);
}
else Console.WriteLine("вы вели неверное число");

int DecToDin(int num)
{
    int count = 1;
    int result = 0;
    while (num > 0)
    {
        result += num % 2 * count; 
        num /= 2;
        count = count * 10;
    }
    return result;
}

