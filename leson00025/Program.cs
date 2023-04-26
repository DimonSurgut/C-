//  Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.

Console.WriteLine("Введите число");
double number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа");
int stepn = Convert.ToInt32(Console.ReadLine());

double result = NumerStepn(number, stepn);
Console.WriteLine($"Степень {stepn} числа {number} = {result}");


double NumerStepn (double num, int step)
{
    double sum = 1;
    for (int i = 0; i <= step; i++)
    {
        sum *= num;
    }
   return sum;
}