//В прямоугольной матрице найти строку с наименьшей суммой элементов.

void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

int SummaMin (int[,] array)
{
    int minsum = 0;
    int num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) num = sum;
        else if (sum < num)
        {
            num = sum;
            minsum = i;
        }
    }
    return minsum;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 4;

int[,] array = new int[m, n];
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine ($"Строка с наименьшей суммой элементов  {SummaMin(array)}");