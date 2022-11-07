// 54. В матрице чисел найти сумму элементов главной диагонали
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrix(int rows, int collumns, int min, int max)
{
    int[,] matrix = new int[rows, collumns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max);
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
            Console.Write($"{matrix[i,j], 2}");
        }
        Console.WriteLine("|");
    }
}
int SunElementsOfMainDiaginal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j) sum = sum + matrix[i,j];
            if(j > matrix.GetLength(1)) break;
        }
    }
    return sum;
}
int[,] matrix = CreateMatrix(m, n, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int res = SunElementsOfMainDiaginal(matrix);
Console.WriteLine($"Сумма элементов главной диагонали двумерного массива равна: {res}!");
