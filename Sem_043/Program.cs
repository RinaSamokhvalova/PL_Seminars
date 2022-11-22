// Семинар 6. Домашнее задание.
// Задача 43 (ДЗ). Напишите программу, которая найдет точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionSearch (double b1, double k1, double b2, double k2)
{
    double[] res = new double[2];
    res[0] = (b2 - b1) / (k1 - k2);
    res[1] = k1 * res[0] + b1;
    return res;
}

Console.WriteLine("Две прямые задаются уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.Write ("Введите число k1: ");
int lk1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите число b1: ");
int lb1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите число k2: ");
int lk2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите число b2: ");
int lb2 = int.Parse(Console.ReadLine() ?? "0");
double[] point = IntersectionSearch (lb1, lk1, lb2, lk2);
Console.WriteLine($"Точкой пересечения прямых y = {lk1} * x + {lb1}, y = {lk2} * x + {lb2} является точка ({point[0]}, {point[1]})");