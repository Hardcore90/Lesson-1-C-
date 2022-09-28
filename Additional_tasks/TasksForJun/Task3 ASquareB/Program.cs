// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

void Square(int a, int b)
{
    if(a == b * b) Console.WriteLine($"Число {a} является квадратом числа {b}");
    else Console.WriteLine($"Число {a} НЕ является квадратом числа {b}");
    if(b == a * a) Console.WriteLine($"Число {b} является квадратом числа {a}");
    else Console.WriteLine($"Число {b} НЕ является квадратом числа {a}");
}
Square(n1,n2);