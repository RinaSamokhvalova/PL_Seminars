// Задача 23. Напишите программу, которая принимает на вход 
// число (N) и выдает таблицу квадратов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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
        Console.Write ($"{Math.Pow((index),3)} ");
        index = index + 1;
    }
}
Console.WriteLine ();