// Console.WriteLine("Hello, World!");


// Console.Write("Введите ваше имя ");
// string username = Console.ReadLine();
// Console.Write("Привет, ");
// Console.Write(username);

//                  Сумма двух чисел!
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// sum = a + b;
// Console.Write("Сумма двух чисел равна ");
// Console.WriteLine(sum);


//                  Деление двух чисел с возможностью результата с вещественными числами!
// Console.Write("Введите первое число: ");
// double a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a / b);


//                       Сумма двух рандомных чисел в диапозоне от 1 до 9!
// int numA = new Random().Next(1, 10);
// Console.WriteLine(numA);
// int numB = new Random().Next(1, 10);
// Console.WriteLine(numB);
// Console.WriteLine(numA + numB);


//                       Привет,Маша!
// Console.Write("Введите имя пользователя: ");
// string username = Console.ReadLine();
// if(username.ToLower() == "маша")
// {
//     Console.WriteLine("Ура, это же МАША!");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }



//                             Найти максимальное из 5 данных чисел!
// int a = 3;
// int b = 8;
// int c = 1;
// int d = 2;
// int e = 6;
// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;

// Console.Write("max = ");
// Console.WriteLine(max);


//                          Треугольники!
// Console.Clear();
// int xa = 1, ya = 1,
//     xb = 1, yb = 25,
//     xc = 40, yc = 25;
// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");
// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");
// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// int x = xa, y = xb;

// int count = 0;
// while(count < 10000)
// {
//     int what = new Random().Next(0, 3);
//     if(what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }
//     if(what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }
//     if(what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }

//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count++;
// }



//                  Максимум из 9 данных чисел.
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int a1 = 15;
// int b1 = 22;
// int c1 = 33;
// int a2 = 11;
// int b2 = 67;
// int c2 = 45;
// int a3 = 31;
// int b3 = 1112;
// int c3 = 65;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// // int max = Max(max1, max2, max3);

// int max = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));

// Console.WriteLine(max);



//              Нахождение максимального из 9 чисел(Массив)
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };

// array[0] = 12;
// Console.WriteLine(array[4]);

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );

// Console.WriteLine(result);



//              Поиск позиции искомого элемента
// int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

// int n = array.Length;
// int find = 18;
// int index = 0;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);


