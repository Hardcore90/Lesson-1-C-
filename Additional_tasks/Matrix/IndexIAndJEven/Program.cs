// 52. В двумерном массиве заменить элементы, 
// у которых оба индекса чётные на их квадраты
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
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
void ReplaceEvenIAndJElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 & j % 2 == 0) matrix[i,j] *= matrix[i,j];
        }
    }
}
int[,] matrix = CreateMatrix(m, n, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
ReplaceEvenIAndJElements(matrix);
PrintMatrix(matrix);