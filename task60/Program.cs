// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int x = InputNumbers("Введите Х: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine();
int[,,] array3D = new int[x, y, z];
FillArray(array3D);
PrintArray(array3D);


int InputNumbers(string inMessage)
{
    Console.Write(inMessage);
    int outMessage = Convert.ToInt32(Console.ReadLine());
    return outMessage;
}

void FillArray(int[,,] array3D)
{
    int count = 10;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[k, i, j] +=count;
                count += 3;
            }
        }
    }
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i,j,k]} ({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
    }
}
