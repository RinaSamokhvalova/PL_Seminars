// Семинар 9. Домашнее задание.
// Задача 66. Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите натуральное число N: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");

if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна {SumNaturalNumbers(numberM, numberN)}");

int SumNaturalNumbers(int m, int n)
{
    if (n == m) return m;
    else return SumNaturalNumbers(m, n - 1) + n;
}