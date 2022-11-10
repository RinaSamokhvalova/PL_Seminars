// Семинар 4.
// Задача 26. Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountDig (int number)
{
    int count = 0;
    while (number > 0)
    {
        count = count + 1;
        number = number / 10;
    }
    return count;
}

Console.Write ("Введите натуральное число: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine ($"Исходное число: {numberN}");
Console.WriteLine ($"количество разрядов в числе: {CountDig (numberN)}");