﻿// Принимает на вход коодинаты двух точек
// и находит растояние между ними 

// double b = Math.Sqrt(5);
// double b1 = 5.03455;
// double b1Round = Math.Round (b1, 2, MidpointRounding.ToZero);
// Console.WriteLine(b1Round);

Console.WriteLine ("Введите координаты A");
Console.Write ("значение х");
int x1Coordinati = Convert.ToInt32(Console.ReadLine());
Console.Write ("значение y");
int y1Coordinati = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты B");
Console.Write ("значение х");
int x2Coordinati = Convert.ToInt32(Console.ReadLine());
Console.Write ("значение y");
int y2Coordinati = Convert.ToInt32(Console.ReadLine());


double distance = Renge (x1Coordinati, y1Coordinati, x2Coordinati, y2Coordinati);
double distRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine(distRound);


double Renge (int x1, int y1, int x2, int y2)
{
    int deltaX = x1 - x2;
    int deltaY = y1 - y2;
    double renge = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    return renge;
}