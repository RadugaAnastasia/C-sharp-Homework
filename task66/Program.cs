// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Далее будет необходимо ввести 2 числа M и N. ВАЖНО! M < N!");
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int temp = M;
Console.WriteLine($"Сумма натуральных чисел в промежутке от M = {M} до N = {N} -> {SumDigit(M, N, temp = 0)}");

int SumDigit(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        return sum;
    }
    return SumDigit(m, n-1, sum);
}