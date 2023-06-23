// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = Prompt("Введите размерность массива: ");
int[] array = GetArray(size);
PrintArray(array);
Console.Write(" -> ");
SerchEven(array);


int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int [] GetArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
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
    Console.Write($"{arr[arr.Length - 1] }");
    Console.Write(" ]");
}
void SerchEven(int[] arr)
{
    int index = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            index++;
        }
    }
    Console.Write(index);
}