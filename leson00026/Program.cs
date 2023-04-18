// Принимает на входе число
// выдает количество цифр в числе

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


int kolichestvo = Numbers(number);
Console.WriteLine($"число {number} состоит из {kolichestvo} чисел");


int Numbers(int num)
{
    int count = 0;
    while (num!= 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}