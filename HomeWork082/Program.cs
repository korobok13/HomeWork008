// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[] SumRowInArray(int[,] BiArray)
{
    int[] result = new int[BiArray.GetLength(0)];
    int k = 0;
    for (int i = 0; i < BiArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < BiArray.GetLength(1); j++)
        {
            sum += BiArray[i, j];
        }
        result[k++] = sum;
    }
    return result;
}
void FindRowMinSum(int[] arr)
{
    int minSum = arr[0];
    int rowMinSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minSum)
        {
            minSum = arr[i];
            rowMinSum = i;
        }
    }
Console.Write($"Наименьшая сумма элементов массива равна: {minSum}, которая находится в строке с индексом: {rowMinSum}. ");
}
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
int[] newMass = SumRowInArray(array);
Console.WriteLine();
FindRowMinSum(newMass);