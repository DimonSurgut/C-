// Напишите программу, 
// которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите трехзначное число");
int number = Convert.ToInt32 (Console.ReadLine());

while (number > 999)
{
    number = number / 10;  
}

if (number < 100)
{
    Console.WriteLine("Третей цифры нет");
}
else
{
    int result = number % 10;
    Console.WriteLine ($"Третья цифра числа {result}");
}

