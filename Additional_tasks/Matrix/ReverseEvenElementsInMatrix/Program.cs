// 50. В двумерном массиве n×k заменить четные элементы на противоположные

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrix(int n, int k, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[n, k];
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
void ReverseEvenElementsInMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] % 2 == 0) matrix[i,j] = - matrix[i,j];
        }
    }
}
int[,] matrix = CreateMatrix(n, k, -9, 10);
PrintMatrix(matrix);
Console.WriteLine();
ReverseEvenElementsInMatrix(matrix);
PrintMatrix(matrix);
