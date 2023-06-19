// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine()!);
    return number;
}

int ReverseNumber(int num)
{
    int n = num; //сохраняет заданное целое число
    int k = 0; // хранит перевернутое число
    while (n>0)
    {
        k = 10*k + n % 10; 
        n /= 10; //n = n / 10 - удаляем последнюю цифру из n
    }
    return (k);
}

int N = Prompt("Введите пятизначное число: ");

if(N >= 10000 && N < 100000)
{
    if(N == ReverseNumber(N))
    {
        Console.WriteLine($" {N} -> да");
    }
    else
    {
        Console.WriteLine($" {N} -> нет");
    }
}
else
{
    Console.WriteLine("Введенное число не является пятизначным!");
}