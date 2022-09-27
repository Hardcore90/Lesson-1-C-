// ## Почувствуй себя интерном*

//  0. Вывести квадрат числа

//  1. По двум заданным числам проверять является ли первое квадратом второго

//  2. Даны два числа. Показать большее и меньшее число

//  3. По заданному номеру дня недели вывести его название

//  4. Найти максимальное из трех чисел

//  5. Написать программу вычисления значения функции y = f(a)

//  6. Выяснить является ли число чётным

//  7. Показать числа от -N до N

//  8. Показать четные числа от 1 до N

//  9. Показать последнюю цифру трёхзначного числа

// 10. Показать вторую цифру трёхзначного числа

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// 12. Удалить вторую цифру трёхзначного числа

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// 14. Найти третью цифру числа или сообщить, что её нет


//  0. Вывести квадрат числа

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Квадрат от числа {n} равен {n * n}!");


//  1. По двум заданным числам проверять является ли первое квадратом второго

// Console.WriteLine("Введите первое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if(n1 == n2 * n2) Console.WriteLine($"{n1} является квадратом {n2}!");
// else Console.WriteLine($"{n1} НЕ является квадратом {n2}!");


//  2. Даны два числа. Показать большее и меньшее число

// Console.WriteLine("Введите первое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// if(n1 == n2) Console.WriteLine("Числа равны!");
// else if(n1 > n2) Console.WriteLine($"Большее: {n1}, Меньшее: {n2}");
// else Console.WriteLine($"Большее: {n2}, Меньшее: {n1}");



//  3. По заданному номеру дня недели вывести его название

// Console.WriteLine("Введите порядковый номер дня недели: ");
// string day = Console.ReadLine();
// if(day == "1") Console.WriteLine("Понедельник!");
// else if(day == "2") Console.WriteLine("Вторник!");
// else if(day == "3") Console.WriteLine("Среда!");
// else if(day == "4") Console.WriteLine("Четверг!");
// else if(day == "5") Console.WriteLine("Пятница!");
// else if(day == "6") Console.WriteLine("Суббота!");
// else if(day == "7") Console.WriteLine("Воскресенье!");
// else Console.WriteLine("Такого дня недели не существует!");


// 4. Найти максимальное из трех чисел

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третие число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;
// if(b > max) max = b;
// else if(c > max) max = c;
// Console.WriteLine($"{a}, {b}, {c} -> Максимальное: {max}");


//  5. Написать программу вычисления значения функции y = f(a)

// Console.WriteLine("Введите a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int y = 0;
// if(a > 0) y = 2 * a - 10;
// else if(a == 0) y = 0;
// else y = 2 * Math.Abs(a) - 1;
// Console.WriteLine($"{y} = f({a})");

//  6. Выяснить является ли число чётным

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if(n % 2 == 0) Console.WriteLine($"Число {n} является чётным!");
// else Console.WriteLine($"Число {n} НЕ является чётным!");



// 7. Показать числа от -N до N

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int count = -n;
// while(count <= n) 
// {
// Console.Write($"|{count}| ");
// count++;
// }



// 8. Показать четные числа от 1 до N

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int count = 1;
// while(count <= n)
// {
//     if(count % 2 == 0)
//     Console.Write($"{count} ");
//     count++;
// }



// 9. Показать последнюю цифру трёхзначного числа

// Console.WriteLine("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void ThirdDigit(int num)
// {
//     int res = 0;
//     if(num / 1000 == 0 && num / 100 > 0)
//     {
//         res = num % 10;
//         Console.WriteLine($"Последняя цифра трехзначного числа {num} -> {res}!");
//     }
//     else Console.WriteLine($"Число {num} НЕ является трехзначным числом!");
// }

// ThirdDigit(n);



// 10. Показать вторую цифру трёхзначного числа

// Console.WriteLine("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void SecondDigit(int num)
// {
//     int res = 0;
//     if(num / 1000 == 0 && num / 100 > 0)
//     {
//         res = num / 10 % 10;
//         Console.WriteLine($"Вторая цифра трехзначного числа {num} -> {res}!");
//     }
//     else Console.WriteLine($"Число {num} НЕ является трехзначным числом!");
// }

// SecondDigit(n);


// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// int number = new Random().Next(10, 100);
// if(number % 10 > number /10) Console.WriteLine($"Наибольшая цифра числа {number}: {number % 10}");
// else Console.WriteLine($"Наибольшая цифра числа {number}: {number / 10}");



// 12. Удалить вторую цифру трёхзначного числа

// Console.WriteLine("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void DeleteSecondDigit(int num)
// {
//     int res = 0;
//     if(num / 1000 == 0 && num / 100 > 0)
//     {
//         res = num / 100 * 10 + num % 10;
//         Console.WriteLine($"Вторая цифра трехзначного числа {num} -> {res}!");
//     }
//     else Console.WriteLine($"Число {num} НЕ является трехзначным числом!");
// }

// DeleteSecondDigit(n);


// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// void Multiply(int n1,int n2)
// {
//     int res = 0;
//     if(n1 % n2 == 0) Console.WriteLine($"Число {n1} является кратным числу {n2}");
//     else
//     {
//         res = n1 % n2;
//         Console.WriteLine($"Остаток от деления числа {n1} на число {n2} равен {res}!");
//     }
// }
// Multiply(num1,num2);


// 14. Найти третью цифру числа или сообщить, что её нет

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int ThirdDigit(int n)
// {
//     while(n / 1000 > 0)
//     {
//         n = n / 10;
//     }
//     return n % 10;
// }
// if(number / 100 > 0)
// {
//     int res = ThirdDigit(number);
//     Console.WriteLine($"Третья цифра числа {number} -> {res}!");
// }
// else Console.WriteLine("Третьей цифры нет!");