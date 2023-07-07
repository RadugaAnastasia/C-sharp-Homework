﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Все числа в промежутке от 1 до {N}: {Range(N)} ");

string Range(int N)
{
    if (N == 1)
    {
        return "1";
    
    }
    return N + ", " + Range(N - 1);
}