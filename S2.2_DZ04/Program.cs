// Сесминар 2.2 - Домашнее задание. Задача 4
// Найти расстояние между точками в пространстве 2D/3D

Console.Write ("Введите координату X для первой точки: ");
int X1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите координату Y для первой точки: ");
int Y1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите координату Z для первой точки: ");
int Z1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write ("Введите координату X для второй точки: ");
int X2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите координату Y для второй точки: ");
int Y2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите координату Z для второй точки: ");
int Z2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ($"Точка A({X1}, {Y1}, {Z1})"); 
Console.WriteLine ($"Точка B({X2}, {Y2}, {Z2})"); 

double Squareroot = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2) + Math.Pow((Z2 - Z1),2));
Console.WriteLine ($"Расстояние между двумя точками в пространстве равно {Squareroot}");
