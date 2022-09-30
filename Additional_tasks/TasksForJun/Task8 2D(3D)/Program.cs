// 22. Найти расстояние между точками в пространстве 2D/3D

// Console.WriteLine("Введите координаты точек: ");
// Console.WriteLine("X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double Distance(int argX1, int argY1, int argX2, int argY2)
// {
//     double res = Math.Sqrt(Math.Pow((argX2 - argX1), 2) + Math.Pow((argY2 - argY1), 2));
//     return res;
// }

// double distance = Math.Round((Distance(x1, y1, x2, y2)),2,MidpointRounding.ToZero);
// Console.WriteLine($"Расстояние между точками в 2D пространстве - {distance}");




Console.WriteLine("Введите координаты точек: ");
Console.WriteLine("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int argX1, int argY1, int argX2, int argY2, int argZ1, int argZ2)
{
    double res = Math.Sqrt(Math.Pow((argX2 - argX1), 2) + Math.Pow((argY2 - argY1), 2) + Math.Pow((argZ2 - argZ1), 2));
    return res;
}

double distance = Math.Round((Distance(x1, y1, x2, y2, z1, z2)),2,MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками в 3D пространстве - {distance}");