// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int GetExp(int a, int b)
{
    int res = a;
    for(int i = 2; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}

int A = Prompt("Введите число А: ");
int B = Prompt("Введите число В: ");
int result = GetExp(A, B);
Console.WriteLine($"{A}, {B} -> {result}");