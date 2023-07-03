// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите элементы через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
PrintArray(arr);
Console.Write($" -> ");
CountArray(arr);

void CountArray(int[] arr)
{   
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
             count++;
        }
    }
   Console.Write($"{count}");
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}