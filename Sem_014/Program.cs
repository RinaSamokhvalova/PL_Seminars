// Задача 14. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
// Сесминар 2.2 - Задача 1

Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if ((number % 7 == 0) && (number % 23 == 0)) 
{
    Console.WriteLine ($"Число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine ($"Число {number} не кратно 7 и 23");
}