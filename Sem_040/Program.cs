// Семинар 6.
// Задача 40. Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool TriangleCheck (int num1, int num2, int num3)
{
    bool res = false;
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) res = true;
    return res;
}

Console.Write ("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите творое число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine() ?? "0");
bool flag = TriangleCheck (number1, number2, number3);
if (flag == true)
{
    Console.WriteLine($"Треугольник со сторонами {number1}, {number2}, {number3} существовать может");
}
else Console.WriteLine($"Треугольник со сторонами {number1}, {number2}, {number3} существовать не может");