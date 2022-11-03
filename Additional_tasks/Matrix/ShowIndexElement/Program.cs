// 53. В двумерном массиве показать позиции числа, 
// заданного пользователем или указать, 
// что такого элемента нет

Console.WriteLine("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int m, int n, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min,max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j],2} ");
        }
        Console.WriteLine("|");
    }
}
void ShowIndexOfFindElelement(int[,] matrix, int number)
{
    int flag = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == number) 
            {
                Console.WriteLine($"Позиции числа {number} =>[{i},{j}]!");
                flag = 1;
            }
        }
    }
    if(flag == 0) Console.WriteLine("Такого числа в массиве нет!");
}
int[,] matrix = CreateMatrix(4,4,1,10);
PrintMatrix(matrix);
Console.WriteLine();
ShowIndexOfFindElelement(matrix, num);