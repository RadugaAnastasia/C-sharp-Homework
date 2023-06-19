// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void Rasst(int xa, int ya, int za, int xb, int yb, int zb)
{
    double AB = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
    Console.WriteLine(AB);
}

int XA = Prompt("Введите координату точки xa: ");
int YA = Prompt("Введите координату точки ya: ");
int ZA = Prompt("Введите координату точки za: ");
int XB = Prompt("Введите координату точки xb: ");
int YB = Prompt("Введите координату точки yb: ");
int ZB = Prompt("Введите координату точки zb: ");
Rasst (XA, YA, ZA, XB, YB, ZB);