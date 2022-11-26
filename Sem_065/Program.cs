// Семинар 9. 
// Задача 65. Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 6, 7, 8"

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
for (int i = numberM; i <= numberN; i++)
    {
        Console.Write($"{NaturalNumbers(i)}, ");
    }

Console.WriteLine();

int NaturalNumbers(int n)
{
    if (n == 1) return 1;
    else return NaturalNumbers(n - 1) + 1;
}