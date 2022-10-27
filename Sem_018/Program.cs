// Задача 18. Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write ("Введите число обозначающее номер четверти координатной плоскости: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number > 0 && number < 5)
{
    if (number == 1) Console.WriteLine ("В первой четверти X > 0; Y > 0");
    if (number == 2) Console.WriteLine ("Во второй четверти X < 0; Y > 0");
    if (number == 3) Console.WriteLine ("В третьей четверти X < 0; Y < 0");
    if (number == 4) Console.WriteLine ("В четвертой четверти X > 0; Y < 0");
}
else 
{
    Console.WriteLine ("Введено некорректное число");
}