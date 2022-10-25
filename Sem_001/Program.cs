// 1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.Write ("Введите число: ");
// int numberA = int.Parse(Console.ReadLine()); - выдает ошибку
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите квадрат введенного вами числа: ");
// int numberB = int.Parse(Console.ReadLine());  - выдает ошибку
int numberB = int.Parse(Console.ReadLine() ?? "0");

if (numberA * numberA == numberB)
{
    Console.WriteLine($"Правильно! Квадрат числа {numberA} равен {numberB}.");
}
else 
{
    Console.WriteLine($"Не верно! Квадрат числа {numberA} не равен {numberB}.");
}