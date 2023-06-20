// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GetSum(int n)
{
    int sum = 0;
    while(n > 0)
    {
        int lastValue = n % 10;
        sum = sum + lastValue;  
        n /= 10;
    }
    return sum;
}

int N = Prompt("Введите число N: ");
int result = GetSum(N);
Console.WriteLine($"{N} -> {result}");
