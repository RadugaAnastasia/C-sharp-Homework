﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите границы диапазона массива от: ");
int maxValue = Prompt("Введите границы диапазона массива до: ");
double[] randomArray = new double[size];
GetandPrintArray(size, minValue, maxValue);
Console.Write(" => ");
DiffArray(randomArray);

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void GetandPrintArray(int a, int minValue,int maxValue)
{
    Console.Write("[  ");
    Random rand = new Random();
    for(int i = 0; i < a ; i++)
    {
        randomArray[i] = rand.NextDouble()*(maxValue - minValue) + minValue;
        Console.Write($"{randomArray[i]:F4}  ");
    }
    Console.Write("]");
}

void DiffArray(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    double result = 0;
    int i = 0;
    while(i < randomArray.Length)
    {
        if(max < randomArray[i])
        max = randomArray[i];
        if(min > randomArray[i])
        min = randomArray[i];
        i++;
    }
    result = max - min;
    Console.Write($"{max:F4} - {min:F4} = {result:F4}");
}

//Решение от Эльвиры
Console.Clear();
double[] startArray = GetArray(5);
Console.WriteLine(String.Join(" | ", startArray)); // String.Join присоединяет каждый элемент массива через разделитель
Console.WriteLine($"Разница = {GetDifference(startArray)}");

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 10 + new Random().Next();
        res[i] = Math.Round(res[i], 3); //округляем до 3х знаков
    }
    return res;
}

double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (double el in array)
    {
        if (min > el) min = el;
        if (max < el) max = el;
    }
    return max - min;
}