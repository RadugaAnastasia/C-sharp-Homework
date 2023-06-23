// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число диапазона массива: ");
int maxValue = Prompt("Введите максимальное число диапазона массива: ");
Console.WriteLine("Внимание! Первый элемент массива (позиция 0) учитываем как элемент, стоящий на четной позиции");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.Write(" -> ");
GetSum(array);


int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write(" ]");
}
void GetSum(int[] array)
{
    int evenSum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
        {
            evenSum += array[i];
        }
        // evenSum += array[0];
    }
    Console.Write(evenSum);
}