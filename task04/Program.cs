// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse (Console.ReadLine()!);
if (a > b) 
{
    if (a > c) 
    { 
       Console.WriteLine($" {a}, {b}, {c} -> {a}");
    }
    else
    {
        Console.WriteLine($" {a}, {b}, {c} -> {c}");
    }
}
else 
{
    if (b > c) 
    { 
       Console.WriteLine($" {a}, {b}, {c} -> {b}");
    }
    else
    {
        Console.WriteLine($" {a}, {b}, {c} -> {c}");
    }
}