// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)
Console.WriteLine("Ведите целое число");
int number = Convert.ToInt32(Console.ReadLine()); 
int square = number * number;
Console.WriteLine ($"Квадрат число = {square}");