// Семинар 9. 
// Задача 69. Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243
// A = 2; B = 3 -> 8

// возведение в степень
int Exponentiation(int number, int exp)
{
    if (exp == 1) return number;
    else return Exponentiation(number, exp - 1) * number;
}

Console.Write ("Введите натуральное число A: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите натуральное число B: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ($"Чисело {numberA} в степени {numberB} равняется: {Exponentiation (numberA, numberB)}");