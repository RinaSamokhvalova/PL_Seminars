// Задача 17. Напишите программу, которая принимает на вход 
// координаты точки (Х и У), причем X ≠ 0 и Y ≠ 0 
// и выдает номер четверти плоскости, в которой находится точка.

// Сесминар 2.2 - Задача 2

Console.Write ("Введите координату X не равное 0: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите координату Y не равное 0: ");
int y = int.Parse(Console.ReadLine() ?? "0");

if (x == 0 || y == 0)
{
    Console.WriteLine ("Неверно введены координаты");
}
else
{
    if (x > 0)
    {
        if (y > 0)
        {
        Console.WriteLine ("Первая четверть");
        }
        else Console.WriteLine ("Четвертая четверть");
    }
    else
    {
        if (y > 0)
        {
        Console.WriteLine ("Вторая четверть");
        }
        else Console.WriteLine ("Третья четверть");
    }
}
