// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.


Console.Write("ВВедите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0)
    number = -number;
if (number >= 100 && number < +999)
    Console.WriteLine(number % 10);
else
    Console.WriteLine("Ввели не трех знач число");
