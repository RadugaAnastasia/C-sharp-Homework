// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число для минимального диапазона значений: ");
int maxValue = Prompt("Введите число для максимального диапазона значений: ");
Console.WriteLine("Введите номер строки искомого элемента: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца искомого элемента: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
FindElement(array, m, n);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min, max);
        }
    }
    return result;
}

void FindElement(int[,] array, int M, int N)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == M && j ==N)
            {
                Console.WriteLine($"На строке с номером {i} и столбце с номером {j} находится значение {array[i,j]}");
            }
        }
    }
    if(M > array.GetLength(0) || N > array.GetLength(1))
    {
        Console.WriteLine($"[{M},{N}] -> на этой позиции числа в массиве нет");
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength(0) - длина строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) //GetLength(1) - длина столбцов
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}