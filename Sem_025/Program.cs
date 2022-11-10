// Семинар 4. Домашняя работа 
// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// возведение в степень
int Exponentiation (int number, int exp)
{
    int prod = 1;
    for (int i = 1; i <= exp; i++)
    {
        prod = prod * number; 
    }
    return prod;
}

Console.Write ("Введите натуральное число A: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите натуральное число B: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ($"Чисело {numberA} в степени {numberB} равняется: {Exponentiation (numberA, numberB)}");