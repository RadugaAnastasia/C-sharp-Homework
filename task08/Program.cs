// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int.TryParse(Console.ReadLine(), out int result);
string str = "";
for (int i = 1; i <= result; i++ )
{
    if (i % 2 == 0)
    {
        str += " " + i.ToString() + ",";
    }
}
char[] MyChar = {','};
str = str.TrimEnd(MyChar);
Console.WriteLine($" {result} -> \"{str} \"");