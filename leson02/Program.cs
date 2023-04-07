//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Ведите число");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Другое число");
int number_b = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (number_a>number_b)
{
    max=number_a;
    min=number_b;
}
else
{
    max=number_b;
    min=number_a;
}
Console.WriteLine ($"мaксимальное число = {max}");
Console.WriteLine ($"минимальное число = {min}");