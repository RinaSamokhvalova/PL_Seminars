// Семинар 4.
// Задача 28. Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ProductDig (int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
    {
        prod = prod * i; 
    }
    return prod;
}

Console.Write ("Введите натуральное число: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine ($"Исходное число: {numberN}");
Console.WriteLine ($"Произведение чисел от 1 до {numberN}: {ProductDig (numberN)}");