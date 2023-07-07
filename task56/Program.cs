// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

const int rows = 5;
const int columns = 5;
const int minValue = 1;
const int maxValue = 9;

int[,] array = GetRandomArray(rows, columns, minValue, maxValue);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
int minSum = 0;
int sum = FindLineSum(array, 0);
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine($"Строка {i} -> Сумма элементов = {FindLineSum(array, i)}");
    if (sum > FindLineSum(array, i))
    {
        sum = FindLineSum(array, i);
        minSum = i;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum}");


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

//ищет сумму в строке 
int FindLineSum(int[,] arr, int i)
{
    int sum = arr[i,0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        sum += arr[i,j];
    }
    return sum;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}