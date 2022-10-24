// 0.Вывести квадрат числа
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Квадрат числа {num} равен {num * num}!");


// 1. По двум заданным числам проверять является ли первое квадратом второго
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 == num2 * num2) Console.WriteLine($"Первое число {num1} является квадратом второго числа {num2}!");
// else Console.WriteLine($"Первое число {num1} НЕ является квадратом второго числа {num2}!");


//  2. Даны два числа. Показать большее и меньшее число
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 < num2)
// {
//     Console.WriteLine($"Большее число -> {num2}!");
//     Console.WriteLine($"Меньшее число -> {num1}!");
// }
// else
// {
//     Console.WriteLine($"Большее число -> {num1}!");
//     Console.WriteLine($"Меньшее число -> {num2}!"); 
// }


//  3. По заданному номеру дня недели вывести его название
// Console.WriteLine("Введите номер дня недели: ");
// int numOfDay = Convert.ToInt32(Console.ReadLine());
// if(numOfDay == 1) Console.WriteLine("Понедельник!");
// else if(numOfDay == 2) Console.WriteLine("Вторник!");
// else if(numOfDay == 3) Console.WriteLine("Среда!");
// else if(numOfDay == 4) Console.WriteLine("Четверг!");
// else if(numOfDay == 5) Console.WriteLine("Пятница!");
// else if(numOfDay == 6) Console.WriteLine("Суббота!");
// else if(numOfDay == 7) Console.WriteLine("Воскресенье!");
// else Console.WriteLine("Такого дня недели не существует!");



// 4. Найти максимальное из трех чисел
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if(num2 > max) max = num2;
// if(num3 > max) max = num3;
// Console.WriteLine($"Максимальное число из данных трех: {max}");


// 5. Написать программу вычисления значения функции y = f(a)
// Console.WriteLine("Введите значение a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int y = 0;
// if(a > 0) y = 2 * a - 10;
// else if(a == 0) y = 0;
// else y = 2 * Math.Abs(a) - 1;
// Console.WriteLine($"y равен {y}");


// 6. Выяснить является ли число чётным
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 2 == 0) Console.WriteLine($"Число {num} является четным!");
// else Console.WriteLine($"Число {num} НЕ является четным!");


//  7. Показать числа от -N до N
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = -num;
// while(i <= num)
// {
//     Console.Write($"|{i}| ");
//     i++;
// }


// 8. Показать четные числа от 1 до N
// Console.WriteLine("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// while(i <= n)
// {
//     if(i % 2 == 0) Console.Write($"|{i}| ");
//     i = i + 2;
// }


//  9. Показать последнюю цифру трёхзначного числа
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool IsNumberThreeDigit(int n)
// {
//     bool res = false;
//     if(num / 1000 == 0 && num / 100 > 0) res = true;
//     return res;
// }

// if(IsNumberThreeDigit(num))
// {
//     int res = num % 10;
//     Console.WriteLine($"Последняя цифра трехзначного числа -> {res}!");
// }
// else Console.WriteLine($"Число {num} НЕ является трехзначным!");


// 10. Показать вторую цифру трёхзначного числа
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool IsNumberThreeDigit(int n)
// {
//     bool res = false;
//     if(num / 1000 == 0 && num / 100 > 0) res = true;
//     return res;
// }

// if(IsNumberThreeDigit(num))
// {
//     int res = (num / 10) % 10;
//     Console.WriteLine($"Вторая цифра трехзначного числа -> {res}!");
// }
// else Console.WriteLine($"Число {num} НЕ является трехзначным!");