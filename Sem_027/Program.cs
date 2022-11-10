// Семинар 4. Домашняя работа 
// Задача 27. Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Метод

int FindSum (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ($"Сумма цифр числа {number} равна: {FindSum (number)}");