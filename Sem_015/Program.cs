// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write ("Введите число обозначающее день недели: ");
int number = int.Parse(Console.ReadLine() ?? "0");
if (number > 0 && number < 8)
    if (number == 6 || number == 7)
    {
        Console.WriteLine ("Выходной день");
    }
    else 
    {
        Console.WriteLine ("Будний день");
    }
else 
    {
        Console.WriteLine ("Введено некорректное число");
    }