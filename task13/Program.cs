// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
int number = int.Parse (Console.ReadLine()!);
int number1 = number;
int result = -1;
if(number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    result = number % 10;
}
if(result == -1)
{
    Console.WriteLine($" {number1} -> третьей цифры нет");
}
else
{
    Console.WriteLine($" {number1} -> {result}");
}