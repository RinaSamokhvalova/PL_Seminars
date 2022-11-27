// Семинар 9. Домашнее задание.
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число M: ");
double numberM = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
double numberN = Convert.ToDouble(Console.ReadLine());
if (numberN < 0 || numberN < 0)
{
    Console.WriteLine("Введены неподходящие числа");
}
else  
{
Console.WriteLine($"Функция Аккермана для чисел ({numberM}, {numberN}) равна {AckermannFunction(numberM, numberN)}");
}

double AckermannFunction(double m, double n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}