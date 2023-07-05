// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x +b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($" b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y}) ");


//Решение от Эльвиры
Console.Clear();
Console.Write("Введите через пробел b1, k1, b2, k2: ");
string[] f = Console.ReadLine().Split(); //строковый массив через пробел
double b1 = double.Parse(f[0]); //вытаскиваем поэлементно из строкового массива и преобразовываем
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);
// GetPoint(b1, k1, b2, k2);
Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2))); //метод Join выводит в строку поэлементно через пробел на консоль

double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
{
    double[] result = new double[2];
    result[0] = (inB1 - inB2) / (inK1 - inK2);
    result[1] = inK1 * result[0] + inB1;
    // for (int i = 0; i < result.length; i++)
    // {
    //     Console.Write($"{result[i]}");
    // }
    return result;
}