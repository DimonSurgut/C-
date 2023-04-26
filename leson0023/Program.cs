// Принимет на вход число (N)
// выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

TableAllSquares(number);



void TableAllSquares(int num)
{
    int count = 1;
    while (count <= num)
    {
    Console.WriteLine($"{count}   {count * count * count}");
    count++;
    }
}
