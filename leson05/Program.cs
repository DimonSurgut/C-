Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = -numberA;
while (count<=numberA)
{
    Console.Write(count+" ");
    count++;
}