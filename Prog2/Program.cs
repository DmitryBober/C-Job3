// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Console.Write("Введите x1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите z1: ");
// int z1=int.Parse(Console.ReadLine());
// Console.Write("Введите x2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите y2: ");
// int y2=int.Parse(Console.ReadLine());
// Console.Write("Введите z2: ");
// int z2=int.Parse(Console.ReadLine());
// Console.Write("Введите x3: ");
// int x3=int.Parse(Console.ReadLine());
// Console.Write("Введите y3: ");
// int y3=int.Parse(Console.ReadLine());
// Console.Write("Введите z3: ");
// int z3=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2-x3, 2) + Math.Pow(y1-y2-y3, 2) + Math.Pow(z1-z2-z3));

// Console.WriteLine($"d={d:f5}");

Console.Write("Введите X1: ");
int x1=int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1=int.Parse(Console.ReadLine());
Console.Write("Введите z1: ");
int z1=int.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
int x2=int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2=int.Parse(Console.ReadLine());
Console.Write("Введите z2: ");
int z2=int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

Console.WriteLine($"d={d:f3}");