// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void FindThird(int n)
{
    int i = 1;
    while(i <= n)
{
    Console.Write(i*i*i + "  ");
    i ++;
}
}

int N = Prompt("Введите число N: ");
FindThird(N);