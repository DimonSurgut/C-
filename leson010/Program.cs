// Напишите программу которая 
// принимает на входе трехзначное число
// и на выходе показывает ВТОРУЮ цифру этого числа


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 1000 -> {number}");

int result = SecondDigit (number);
Console.WriteLine ($"Вторая цифра числа {result}");

int SecondDigit (int num)
{
    int secondDigit = number % 100;
    int thirdDigit = number % 10;
    int res = (secondDigit - thirdDigit) / 10;
    return res;
}
