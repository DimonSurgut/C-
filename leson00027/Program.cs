// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = Summa(number);
Console.WriteLine ($"Сумма всех цифр числа {number} = {result}");

int Summa(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}