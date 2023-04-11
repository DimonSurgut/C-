Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = Remainder (firstNumber, secondNumber);

// if (result > 0)
// {
//     Console.WriteLine ($"число не кратно, остаток -> {result}");
// }
// else
// {
//     Console.WriteLine ("число кратно");
// }

string res = result > 0 ? $"число не кратно, остаток -> {result}" : "число кратно";
Console.WriteLine(res);

int Remainder (int fNum, int sNum) 
{
    return fNum % sNum;
}
