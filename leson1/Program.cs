// //Напишите программу,которая на входе 
// принимает чмслом и выдает его квадрат (число умноженое само на себя)
Console.WriteLine("Ведите целое число");
int number = Convert.ToInt32(Console.ReadLine()); 
int square = number * number;
Console.WriteLine ($"Квадрат число = {square}");