// Семинар 9. 
// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 
// 45 -> 9

Console.Write ("Введите натуральное число: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");
if (numberN < 1)
{
    Console.WriteLine("Введено неподходящее число");
}
else
{
    Console.WriteLine ($"Сумма цифр в числе равна: {SusDigits(numberN)}");
}

int SusDigits(int number)
{
    if (number < 10) return number;
    else return SusDigits(number / 10) + number % 10;
}