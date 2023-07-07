// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

const int rows1 = 4;
const int columns1 = 4;
const int minValue1 = 1;
const int maxValue1 = 9;

const int rows2 = 4;
const int columns2 = 5;
const int minValue2 = 11;
const int maxValue2 = 25;

int[,] array1 = GetRandomArray(rows1, columns1, minValue1, maxValue1);
Console.WriteLine("Матрица 1: ");
PrintArray(array1);
int[,] array2 = GetRandomArray(rows2, columns2, minValue2, maxValue2);
Console.WriteLine();
Console.WriteLine("Матрица 2: ");
PrintArray(array2);
Console.WriteLine();
if (rows1 == columns2)
{
    int[,] resultarray = new int[rows1, columns2];
    MultiplyArray(array1, array2, resultarray);
    Console.WriteLine("Произведение матриц: ");
    PrintArray(resultarray);
}
else
{
    Console.WriteLine("Умножение матриц совершить невозможно! Проверьте исходные данные!");
}

int[,] GetRandomArray(int row, int col, int min, int max)
{
    int[,] arr = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i,j] = rand.Next(min, max + 1);
        }
    }
    return arr;
}

void MultiplyArray(int[,] array1, int[,] array2, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i,k] * array2[k,j];
            }
            resultArray[i,j] = sum;
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}   ");
        }
        Console.WriteLine();
    }
}