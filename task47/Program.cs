// Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число для минимального диапазона значений: ");
int maxValue = Prompt("Введите число для максимального диапазона значений: ");

double[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble()*(maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength(0) - длина строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) //GetLength(1) - длина столбцов
        {
            Console.Write($"{array[i,j]:F4}  ");
        }
        Console.WriteLine();
    }
}