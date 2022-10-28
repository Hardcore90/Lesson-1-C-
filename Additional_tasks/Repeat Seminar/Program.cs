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


// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int num = new Random().Next(10, 100);
// if(num / 10 > num % 10)
// {
//     Console.WriteLine($"Наибольшая цифра числа {num} -> {num / 10}! ");
// }
// else Console.WriteLine($"Наибольшая цифра числа {num} -> {num % 10}! ");


// 12. Удалить вторую цифру трёхзначного числа
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
//     int firstDigit = num / 100;
//     int lastDigit = num % 10;
//     int res = firstDigit * 10 + lastDigit;
//     Console.WriteLine($"{num} -> {res}!");
// }
// else Console.WriteLine($"Число {num} НЕ является трехзначным!");


// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// int num = new Random().Next(1, 100);
// Console.WriteLine("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// bool IsMultiplay(int arg1, int arg2)
// {
//     bool res = false;
//     if(arg1 % arg2 == 0) res = true;
//     return res;

// }

// if(IsMultiplay(num, num1)) Console.WriteLine($"Число {num} кратно числу {num1} !");
// else Console.WriteLine($"Число {num} НЕ кратно числу {num1}! Остаток от деления равен {num % num1}! ");



// 14. Найти третью цифру числа или сообщить, что её нет
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int ThirdDigit(int number)
// {
//     while(number / 1000 > 0)
//     {
//         number = number / 10;
//     }
//     return number % 10;
// }
// if(num / 100 == 0) Console.WriteLine("Нет третьей цифры!");
// else
// {
//     int res = ThirdDigit(num);
//     Console.WriteLine($"Третья цифра числа {num} -> {res}!");
// }


//                  Почувствуй себя джуном*

// 15. Дано число. Проверить кратно ли оно 7 и 23
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// void IsMultiplay7And23(int number)
// {
//     if(number % 7 == 0 && number % 23 == 0)
//     {
//         Console.WriteLine($"Число {number} кратно 7 и 23!");
//     }
//     else Console.WriteLine($"Число {number} НЕ кратно 7 и 23!");
// }
// IsMultiplay7And23(num);


// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
// Console.WriteLine("Введите номер дня недели: ");
// int numOfDay = Convert.ToInt32(Console.ReadLine());
// bool IsWeekend(int num)
// {
//     bool res = false;
//     if(num == 6 || num == 7) res = true;
//     return res;
// }
// if(IsWeekend(numOfDay)) Console.WriteLine("Выходной!");
// else if(numOfDay == 1) Console.WriteLine("Понедельник!");
// else if(numOfDay == 2) Console.WriteLine("Вторник!");
// else if(numOfDay == 3) Console.WriteLine("Среда!");
// else if(numOfDay == 4) Console.WriteLine("Четверг!");
// else if(numOfDay == 5) Console.WriteLine("Пятница!");
// else Console.WriteLine("Такого дня недели не существует!");


// 17. По двум заданным числам проверять является ли одно квадратом другого
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// void IsSquareOfAnotherNumber(int number1, int number2)
// {
//     if(number1 == number2 * number2) Console.WriteLine($"Число {number1} является квадратом числа {number2}!");
//     else if(number2 == number1 * number1) Console.WriteLine($"Число {number2} является квадратом числа {number1}!");
//     else Console.WriteLine($"Числа не являются квадратом другого!");
// }
// IsSquareOfAnotherNumber(num1, num2);



// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// bool F(bool X, bool Y)
// {
//     return (!(X || Y) == ((!X) && (!Y)));
// }
// Console.WriteLine(F(false,false));


// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// Console.WriteLine("Введите X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int PlaneNumber(int x1, int y1)
// {
//     int planeNumber = 0;
//     if(x1 < 0 && y1 < 0) planeNumber = 4;
//     else if(x1 > 0 && y1 > 0) planeNumber = 2;
//     else if(x1 > 0 && y1 < 0) planeNumber = 1;
//     else if(x1 < 0 && y1 > 0) planeNumber = 3;
//     return planeNumber;
// }
// if(x == 0 && y == 0) Console.WriteLine("Координаты точки равны 0!");
// else 
// {
//     int res = PlaneNumber(x, y);
//     Console.WriteLine($"Номер плоскасти, в который находится точка -> {res}!");
// }



// 20. Задать номер четверти, показать диапазоны для возможных координат
// Console.WriteLine("Введите номер плоскасти: ");
// int planeNumber = Convert.ToInt32(Console.ReadLine());
// void Cordinates(int plane)
// {
//     if(plane == 1) Console.WriteLine("Диапозон для возможных координат X > 0, Y < 0!");
//     else if(plane == 2) Console.WriteLine("Диапозон для возможных координат X > 0, Y > 0!");
//     else if(plane == 3) Console.WriteLine("Диапозон для возможных координат X < 0, Y > 0!");
//     else if(plane == 4) Console.WriteLine("Диапозон для возможных координат X < 0, Y < 0!");
//     else Console.WriteLine("Такой плоскасти не существует!");
// }
// Cordinates(planeNumber);



// 21. Программа проверяет пятизначное число на палиндромом.
// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool IsFiveDigitNumber(int num)
// {
//     return num / 10000 == 0 || num / 100000 > 0;
// }
// bool IsPalidrom(int num)
// {
//     bool res = false;
//     if(num % 10 == num / 10000 & (num / 1000) % 10 == (num / 10) % 10)
//     {
//         res = true;
//     }
//     return res;
// }
// if(IsFiveDigitNumber(number)) Console.WriteLine($"Число {number} НЕ является пятизначным!");
// else if(IsPalidrom(number)) Console.WriteLine($"Число {number} является палидромом!");
// else Console.WriteLine($"Число {number} НЕ является палидромом!");



// 22. Найти расстояние между точками в пространстве 2D/3D
// Console.WriteLine("Введите координаты точек!");
// Console.WriteLine("X1:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y1:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Z1:");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("X2:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y2:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Z2:");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double Distance(int argX1, int argY1, int argZ1, int argX2, int argY2, int argZ2)
// {
//     double res = Math.Sqrt(Math.Pow((argX2 - argX1), 2) + Math.Pow((argY2 - argY1), 2) + Math.Pow((argZ2 - argZ1), 2));
//     return res;
// }

// double res = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 1, MidpointRounding.ToZero);
// Console.WriteLine($"Расстояние между точками в пространстве 3D: {res}!");



// 23. Показать таблицу квадратов чисел от 1 до N 
// Console.WriteLine("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void TableOfSquares(int num)
// {
//     int res = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         res = i * i;
//         Console.WriteLine($"| {i} | {res} |");
//     }
//     Console.WriteLine();
// }
// TableOfSquares(n);



// 24. Найти кубы чисел от 1 до N
// Console.WriteLine("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void NumInCube(int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.Write($" {i * i * i} ");
//     }
// }
// Console.Write($"{n} -> ");
// NumInCube(n);



//  Найти сумму чисел от 1 до А
// Console.WriteLine("Введите A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int SumOfAllNumbersToA(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// int res = SumOfAllNumbersToA(a);
// Console.WriteLine($"Сумма чисел от 1 до {a} -> {res}!");



// 26. Возведите число А в натуральную степень B используя цикл
// Console.WriteLine("Введите A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// void ToDegree(int num1, int num2)
// {
//     int res = 1;
//     for (int i = 1; i <= num2; i++)
//     {
//         res = res * num1;
//     }
//     Console.WriteLine($"{num1} в степени {num2} -> {res}");
// }
// ToDegree(a, b);



// 27. Определить количество цифр в числе
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int CountDigit(int number)
// {
//     int count = 1;
//     while(number / 10 > 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }
// int res = CountDigit(num);
// Console.WriteLine($"Количество цифр в числе {num} -> {res}!");



// 28. Подсчитать сумму цифр в числе
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int SumDigitsOfNumber(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         sum = sum + (number % 10);
//         number = number / 10;
//     }
//     return sum;
// }
// int res = SumDigitsOfNumber(num);
// Console.WriteLine($"Сумма цифр числа {num} -> {res}!");



// Написать программу вычисления произведения чисел от 1 до N
// Console.WriteLine("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int MultiplyFrom1ToN(int num)
// {
//     int res = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         res = res * i;
//     }
//     return res;
// }
// int result = MultiplyFrom1ToN(n);
// Console.WriteLine($"Произведение чисел от 1 до {n} -> {result}!");



// 30. Показать кубы чисел, заканчивающихся на четную цифру
// int number = new Random().Next(1, 100);
// void CubeOfNumberIfEvenLastDigit(int num)
// {
//     if (num % 2 == 0)
//     {
//         Console.WriteLine($"{num} -> {num * num * num}");
//     }
//     else
//     {
//         Console.WriteLine($"{num} -> Последняя цифра не четная!");
//     }
// }
// CubeOfNumberIfEvenLastDigit(number);



// 31. Задать массив из 8 элементов и вывести их на экран 
// int[] arr = new int[8];
// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1,10);
//     }
//     return array;
// }
// int[] PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// FillArray(arr);
// PrintArray(arr);



// 32.  Задать массив из 8 элементов, заполненных нулями и 
//      единицами вывести их на экран 
// int[] arr = new int[8];
// int[] FillArray0And1(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,2);
//     }
//     return array;
// }
// int[] PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// FillArray0And1(arr);
// PrintArray(arr);



// 33. Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива
// int[] arr = new int[12];
// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//     }
//     return array;
// }
// int[] PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// void SumPositiveAndNegativeNumbers(int[] array)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//         {
//             sumNegative = sumNegative + array[i];
//         }
//         else sumPositive = sumPositive + array[i];
//     }
//     Console.WriteLine($"Сумма положительных чисел: {sumPositive}!");
//     Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}!");
// }

// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// SumPositiveAndNegativeNumbers(arr);



// 34. Написать программу замену элементов массива на противоположные
// int[] arr = new int[12];
// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//     }
//     return array;
// }
// int[] PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// int[] ReverseArrayElements(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = - array[i];
//     }
//     return array;
// }

// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// ReverseArrayElements(arr);
// PrintArray(arr);



// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// Console.WriteLine("Введите искомое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[12];
// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//     }
//     return array;
// }
// int[] PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// int[] ReverseArrayElements(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = - array[i];
//     }
//     return array;
// }
// void FindElementInArray(int[] array, int number)
// {
//     int flag = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(number == array[i]) 
//         {
//             flag = 1;
//             Console.WriteLine($"Число {number} в массиве присутствует!");
//         }
//     }
//     if(flag == 0) Console.WriteLine($"Число {number} не присутствует в массиве!");
// }

// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// FindElementInArray(arr, num);



// 36. Задать массив, заполнить случайными положительными трёхзначными 
// числами. Показать количество нечетных\четных чисел
// int[] arr = new int[6];
// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// int[] PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// void CountOfEvenAndOddNumbers(int[] array)
// {
//     int countEvenNumbers = 0;
//     int countOddNumbers = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0) countEvenNumbers++;
//         else countOddNumbers++;
//     }
//     Console.WriteLine($"Колличество четных чисел в массиве: {countEvenNumbers}!");
//     Console.WriteLine($"Колличество нечетных чисел в массиве: {countOddNumbers}!");
// }
// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// CountOfEvenAndOddNumbers(arr);



// 37. В одномерном массиве из 123 чисел найти количество 
// элементов из отрезка [10,99]
// int[] arr = new int[123];
// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 1000);
//     }
//     return array;
// }
// int[] PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// void CountOfNumbersRangeFrom10to99(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 10 && array[i] < 100) count++;
//     }
//     Console.WriteLine($"Количество элементов в массиве из отрезка [10,99]: {count}!");
// }
// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// CountOfNumbersRangeFrom10to99(arr);



// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// int[] arr = new int[8];
// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }
// int[] PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// int SumElementsInArrayOddIndex(int[] array)
// {
//     int sum = 0;
//     int index = 1;
//     while(index < array.Length)
//     {
//         sum = sum + array[index];
//         index = index + 2;
//     }
//     return sum;
// }
// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов, стоящих на четных позициях в массиве: {SumElementsInArrayOddIndex(arr)}!");



// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// int[] arr = new int[7];
// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }
// int[] PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// int[] MultiplyPairOfNumbers(int[] array)
// {
//     int lengthNewArray = array.Length;
//     if (array.Length % 2 == 0) lengthNewArray = array.Length / 2;
//     else lengthNewArray = (array.Length / 2) + 1;
//     int[] newArray = new int[lengthNewArray];
//     for (int i = 0; i < lengthNewArray; i++)
//     {
//         newArray[i] = array[i] * array[array.Length - i - 1];
//     }
//     if(array.Length % 2 == 1) newArray[lengthNewArray - 1] = array[array.Length / 2];
//     return newArray;
// }
// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// int[] res = MultiplyPairOfNumbers(arr);
// PrintArray(res);



// 40. В Указанном массиве вещественных чисел 
// найдите разницу между максимальным и минимальным элементом
// double[] arr = new double[7];
// double[] FillArray(double[] array, double min, double max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
//     }
//     return array;
// }
// double[] PrintArray(double[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");
//     return array;
// }
// double DifferenceBetweenMaxAndMinElementsArray(double[] array)
// {
//     int i = 0;
//     double minElement = array[0];
//     double maxElement = array[0];
//     while(i < array.Length)
//     {
//         if(array[i] > maxElement) maxElement = array[i];
//         if(array[i] < minElement) minElement = array[i];
//         i++;
//     }
//     return maxElement - minElement;
// }
// FillArray(arr, 1, 10);
// PrintArray(arr);
// Console.WriteLine();
// double res = Math.Round((DifferenceBetweenMaxAndMinElementsArray(arr)),2);
// Console.WriteLine($"Разница между минимальным и максимальным элементом равна: {res}!");



// 