// Принимает на вход число А
// выдает произведение чисел от 1 до А

Console.WriteLine("ввдите число");
int number = Convert.ToInt32(Console.ReadLine());


int sumNumbers = SumNumbers(number);
Console.WriteLine($"Произведение числе от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum * i; 
        }
    }
    return sum;
}