// 00 Напишите программу, которая на вход принимает число и выдаёт его квадрат
// (число умноженное на само себя).

Console.Write ("Введите число: ");
// int number = int.Parse(Console.ReadLine());
int number = int.Parse(Console.ReadLine() ?? "0");
//находим квадрат числа
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}.");