// Семинар 4.
// Задача 24. Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Решение без функций
// Console.Write ("Введите натуральное число: ");
// int numberN = int.Parse(Console.ReadLine() ?? "0");
// int Sum = 0;
// for (int i = 1; i <= numberN; i++)
// {
//     Sum = Sum + i;
// }
// Console.WriteLine(Sum);

int GetSumNumbers (int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
       sum = sum + i;
    }
    return sum;
}

Console.Write ("Введите натуральное число: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(GetSumNumbers(numberA));
