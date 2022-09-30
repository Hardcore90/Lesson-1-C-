// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите координаты точки: ");
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int PlaneNumber(int x1, int y1)
{
    int planeNumber = 0;
    if(x1 == 0 && y1 == 0) planeNumber = 0;
    if(x1 > 0 && y1 > 0) planeNumber = 2;
    else if(x1 < 0 && y1 < 0) planeNumber = 4;
    else if(x1 > 0 && y1 < 0) planeNumber = 3;
    else if(x1 < 0 && y1 > 0) planeNumber = 1;
    return planeNumber;
}
if(x == 0 && y == 0) Console.WriteLine("Координаты равны 0");
else
{
int res = PlaneNumber(x, y);
Console.WriteLine($"{res} четверть!");
}
