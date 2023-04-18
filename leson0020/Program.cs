// Принимает на вход коодинаты двух точек
// и находит растояние между ними 

// double b = Math.Sqrt(5);
// double b1 = 5.03455;
// double b1Round = Math.Round (b1, 2, MidpointRounding.ToZero);
// Console.WriteLine(b1Round);

Console.WriteLine ("Введите координаты A");
Console.Write ("значение х");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("значение y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты B");
Console.Write ("значение х");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("значение y");
int y2 = Convert.ToInt32(Console.ReadLine());



int Renge (int x1, int y1, int x2, int y 2)
{
    int result = (x1 + x2) * (x1 + x2) + (y1 + y1) * (y1 + y2)
    range = Math.Renge (result, 2, MidpointRounding.ToZero)
    return range;
}