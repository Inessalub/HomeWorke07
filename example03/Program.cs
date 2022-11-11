//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }

}

void Replace(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            if ((m % 2 == 0) && (n % 2 == 0)) matrix[m, n] = matrix[m, n] * matrix[m, n];
            Console.Write($"{matrix[m, n]} ");
        }
        Console.WriteLine();
    }
}

int k = 5;
int l = 5;

Console.WriteLine("Изначальный массив: ");

int[,] matrix = new int[k, l];

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();
Console.WriteLine("Новый массив: ");
Replace(matrix);
