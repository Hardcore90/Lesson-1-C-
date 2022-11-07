// 55. Дан целочисленный массив. 
// Найти среднее арифметическое каждого из столбцов.
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
int[] AverageOfMatrixCollumns(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = average + matrix[i,j];
        }
        array[j] = average / matrix.GetLength(1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
int[,] matrix = CreateMatrix(m, n, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов данного двумерного массива равно: ");
int[] averageOfMatrixCollumns = AverageOfMatrixCollumns(matrix);
PrintArray(averageOfMatrixCollumns);