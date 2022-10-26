// Задача 16. Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9  -> нет

Console.Write ("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите еще одно число: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");
int numberTemp;

if (numberB < numberA)
{
    numberTemp = numberA;
    numberA = numberB;
    numberB = numberTemp;
}

if (numberA * numberA == numberB)
{
    Console.WriteLine($"Число {numberB} является квадратом числа {numberA}.");
}
else
{
    Console.WriteLine($"Число {numberB} не является квадратом числа {numberA}.");
}