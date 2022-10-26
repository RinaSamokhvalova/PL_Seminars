// Задача 12. Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write ("Введите первое меньшее число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите второе большее число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

if (number2 % number1 == 0)
{
    Console.WriteLine($"Число {number2} кратно числу {number1}");
}
else Console.WriteLine($"Число {number2} не кратно числу {number1}, остаток от деления равен {number2 % number1}");