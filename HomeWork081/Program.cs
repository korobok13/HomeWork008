// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

var arr = FillMatrix(3, 4);
PrintMatrix(arr);
Console.WriteLine();
var arr1 = SetNumbers(arr);
Console.WriteLine(arr1);

int[,] SetNumbers(int[,] arr)
{
    for (int i = 0; i > arr.GetLength(0); i++)
    {
        int num = 0;
        int max = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            int k = 0;
            while (k != arr.GetLength(1))
            {
                if (max < arr[i, j])
                {
                    max = arr[i, j];
                    j++;
                }
                
                arr[i, j] = arr[i, j - k];
                k++;
            }

        }
    }
    return arr;
}


int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 25);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}

