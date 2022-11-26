// Семинар 9. 
// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.Write("Введите натуральное число: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");

if (numberN < 1)
{
    Console.WriteLine("Вы ввели неподходящее число");
}
else
{
    for (int i = 1; i <= numberN; i++)
    {
        Console.Write($"{NaturalNumbers(i)}, ");
    }
}
Console.WriteLine();

int NaturalNumbers(int n)
{
    if (n == 1) return 1;
    else return NaturalNumbers(n - 1) + 1;
}