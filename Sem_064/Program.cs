// Семинар 9. Домашнее задание.
// Задача 64. Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Write("Введите натуральное число > 1: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");

if (numberN < 2)
{
    Console.WriteLine("Введено неподходящее число");
}
else
{
    for (int i = 2; i <= numberN; i+=2)
    {
        Console.Write($"{NaturalNumbers(i)} ");
    }
}
Console.WriteLine();

int NaturalNumbers(int n)
{
    if (n == 2) return 2;
    else if (n == 3) return 2;
    else return NaturalNumbers(n - 2) + 2;
}