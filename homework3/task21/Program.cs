// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату х первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату у первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z первой точки ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату х  второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату у второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z второй точки ");
int z2 = Convert.ToInt32(Console.ReadLine());

double X = Math.Pow(x2-x1, 2);
double Y = Math.Pow(y2-y1, 2);
double Z = Math.Pow(z2-z1, 2);


double d = Math.Sqrt(X + Y + Z);
Console.WriteLine($"{d:f2}");

