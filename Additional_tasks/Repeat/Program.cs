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



