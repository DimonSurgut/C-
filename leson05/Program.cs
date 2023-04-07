// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.


Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = -numberA;
while (count<=numberA)
{
    Console.Write(count+" ");
    count++;
}