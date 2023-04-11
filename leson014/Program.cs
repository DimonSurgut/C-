Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool result = MultipeTwoDigits(number);

Console.WriteLine(result? "да" : "нет");

bool MultipeTwoDigits(int num)
{
    return num % 7==0 && num % 23 == 0;
}