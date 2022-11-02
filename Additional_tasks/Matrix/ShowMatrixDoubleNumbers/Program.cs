// 49. Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] CreateMatrix(int rows, int collumns, double min, double max)
{
    double[,] matrix = new double[rows, collumns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i,j],2,MidpointRounding.ToZero)} ");
        }
        Console.WriteLine("|");
    }
}
double[,] matrix = CreateMatrix(m, n, 1, 10);
PrintMatrix(matrix);