// // Напишите программу, которая принимает на входе три числа
//  и проверяет, может ли существовать треугольник со сторонами такой днины

Console.WriteLine ("Введите сторону А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите сторону В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите сторону С: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool existTriangle  = IsExistTriangle(numberA, numberB, numberC);
Console.WriteLine(existTriangle ? "Такой треугольник существует" : "Такого треугольника нет");

bool IsExistTriangle(int numA, int numB, int numC);
{
        return numA < numB + numC && numB < numA + numC && numC < numA + numB;
}