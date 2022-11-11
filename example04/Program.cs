//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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
int m = 5;
int n = 5;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
string Position(int[,] array)
{
    string result = string.Empty;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (number == array[m, n]) result += $"Позиция искомого числа: строка {m+1}, столбец {n+1} ";
        }
    }
    if (result == string.Empty) result = "Такого элемента нет";
    return result;
}
Console.WriteLine(Position(array));