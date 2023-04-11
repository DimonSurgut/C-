int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 1000 -> {number}");

int result = DeleteSecondDigit (number);
Console.WriteLine ($"Удоляем вторую цифру числа {result}");


int DeleteSecondDigit (int num) 
{
    int firstNumber = number / 100;
    int thirdNumber = number % 10;
    int res = firstNumber * 10 + thirdNumber;
    return res;
}