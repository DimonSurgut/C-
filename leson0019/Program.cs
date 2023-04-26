// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10000 && number < 100000)
{
    bool result =  Palindrom(number);
    Console.WriteLine(result? "да" : "нет");
}
else
{
    Console.WriteLine("Ввели не пятизначное число");
}



bool Palindrom (int num)
{
    return (num % 10000 == num % 10 && num % 1000 == num % 100);
}

