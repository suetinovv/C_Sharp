// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату 'x' точки А: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату 'y' точки А: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату 'z' точки А: ");
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату 'x' точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату 'y' точки B: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату 'z' точки B: ");
double bz = Convert.ToDouble(Console.ReadLine());

Console.Write($"Растояние между точками А({ax},{ay},{az}) и B({bx},{by},{bz}) = {distance(ax, ay, az, bx, by, bz)}");

// можно было короче, прсто демонстрация функции

double distance(double ax, double ay, double az, double bx, double by, double bz)
{
return Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az));
}
