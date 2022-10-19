// Сесминар 2.2 - Домашнее задание. Задача 3
// Задать номер четверти, показать диапазоны для возможных координат

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
