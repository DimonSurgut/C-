// Принимает на вход коодинаты двух точек
// и находит растояние между ними в 3D простроанстве

Console.WriteLine ("Введите координаты A");
Console.Write ("значение х  ");
int x1Coordinati = Convert.ToInt32(Console.ReadLine());
Console.Write ("значение y  ");
int y1Coordinati = Convert.ToInt32(Console.ReadLine());
Console.Write ("значение z  ");
int z1Coordinati = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты B");
Console.Write ("значение х  ");
int x2Coordinati = Convert.ToInt32(Console.ReadLine());
Console.Write ("значение y  ");
int y2Coordinati = Convert.ToInt32(Console.ReadLine());
Console.Write ("значение z  ");
int z2Coordinati = Convert.ToInt32(Console.ReadLine());


double distance = Renge (x1Coordinati, y1Coordinati, z1Coordinati, x2Coordinati, y2Coordinati, z2Coordinati);
double distRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"растояние между точками = {distRound}");


double Renge (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x1 - x2;
    int deltaY = y1 - y2;
    int deltaZ = z1 - z2;
    double renge = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return renge;
}