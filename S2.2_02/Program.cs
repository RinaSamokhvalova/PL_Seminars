// Сесминар 2.2 - Задача 2
// Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write ("Введите число X: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите число Y: ");
int y = int.Parse(Console.ReadLine() ?? "0");

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