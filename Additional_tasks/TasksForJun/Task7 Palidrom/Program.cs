// 21. Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsFifthDigitNum(int a)
{
    return a / 10000 == 0 || a / 100000 > 0;
}


bool IsPalidrom(int num)
    {
    int n1 = num / 10000;
    int n5 = num % 10;
    int n2 = (num / 1000) % 10;
    int n4 = (num / 10) % 10;
    return n1 == n5 && n2 == n4;
    }

if(IsFifthDigitNum(number)) Console.WriteLine("Число не является пятизначным!");
else 
{
if(IsPalidrom(number)) Console.WriteLine($"{number} -> является палидромом!");
else Console.WriteLine($"{number} -> НЕ является палидромом!");
}






