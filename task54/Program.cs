// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

const int rows = 5;
const int columns = 5;
const int minValue = 1;
const int maxValue = 9;

int[,] array = GetRandomArray(rows, columns, minValue, maxValue);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine("Массив после сортировки по строкам по убыванию: ");

int [] rowSupport = new int[columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        rowSupport[j] = array[i,j];
    }
    SortArray(rowSupport);
    ArrayReplace(true, i, rowSupport, array);
}
PrintArray(array);



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

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
           if (array[j] < array[j+1])
           {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
           }
        }
    }
}

//вспомогательный метод - меняет значение в строке исходного массива на отсортированные значения
void ArrayReplace(bool logicrow, int d, int[] arr1, int[,] array)
{
    for (int k = 0; k < arr1.Length; k++)
    {
        if (logicrow)
            array[d,k] = arr1[k];
        else
            array[k,d] = arr1[k];
    }
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