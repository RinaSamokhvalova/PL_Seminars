// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write ("Введите натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN < 1) 
{
    Console.WriteLine ("Вы ввели неподходящее число");
}
else
{
    int index = 2;
    while (index < numberN)
    {
        Console.Write ($"{index} ");
        index = index + 2;
    }
}
Console.WriteLine ();