// Программа которыя по заданому номеру четверти 
// показывает диапазон возможных координат точек 

Console.WriteLine ("Введите номер четвери");
int quarter = Convert.ToInt32(Console.ReadLine());


string coordint = Quarter (quarter);
Console.WriteLine ($"Значение X и Y входят в диапазон {coordint}");


string Quarter (int quar)
{
    if (quarter == 1) return "x > 0, y > 0";
    if (quarter == 2) return "x < 0, y > 0";
    if (quarter == 3) return "x < 0, y < 0";
    if (quarter == 4) return "x > 0, y < 0";
    return null;
}