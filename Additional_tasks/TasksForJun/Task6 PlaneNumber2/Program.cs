// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: ");
string numPlane = Console.ReadLine();

void Cordinates(string plane)
{
    if(plane == "1") Console.WriteLine("Диапозон расположения координат точки X < 1, Y > 1!");
    else if(plane == "2") Console.WriteLine("Диапозон расположения координат точки X > 1, Y > 1!");
    else if(plane == "3") Console.WriteLine("Диапозон расположения координат точки X > 1, Y < 1!");
    else if(plane == "4") Console.WriteLine("Диапозон расположения координат точки X < 1, Y < 1!");
    else Console.WriteLine("Такой четверти в плоскости нет!");
}

Cordinates(numPlane);