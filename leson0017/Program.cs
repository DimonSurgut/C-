// Принимаем на вход координаты точки (X Y) 
// Х не= 0
// Y не= 0 
// выдает номер четверти плоскости в которой находится точка

Console.WriteLine ("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите y");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x , y);
string result = quarter > 0 
                        ? $"Указаные координаты соответствуют четветри -> {quarter}" 
                        : "Введины не коректные координаты";

Console.WriteLine(result);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}


