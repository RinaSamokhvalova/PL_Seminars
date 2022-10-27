// Задача 22. Напишите программу, которая принимает на вход 
// число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.Write ("Введите натуральное число: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");
if (numberN < 1) 
{
    Console.WriteLine ("Вы ввели неподходящее число");
}
else
{
    int index = 1;
    while (index <= numberN)
    {
        Console.Write ($"{Math.Pow((index),2)} ");
        index = index + 1;
    }
}
Console.WriteLine ();