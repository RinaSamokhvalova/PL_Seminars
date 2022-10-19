// Сесминар 2.2 - Домашнее задание. Задача 2
// По двум заданным числам проверять является ли одно квадратом другого

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