// 47. Написать программу копирования массива

int[] CreateArray(int min, int max)
{
    int[] array = new int[7];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,10);
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],2}, ");
    }
    Console.WriteLine("]");
}
int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
int[] array = CreateArray(1, 10);
PrintArray(array);
Console.WriteLine();
int[] newArray = CopyArray(array);
PrintArray(newArray);