// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.



Console.WriteLine("entr number_a");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("entr number_b");
int number_b = Convert.ToInt32(Console.ReadLine());

if (number_a == number_b*number_b){
    Console.WriteLine("да");
}
else{
    Console.WriteLine ("нет");
}