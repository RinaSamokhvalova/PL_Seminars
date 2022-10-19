// Сесминар 2.2 - Домашнее задание. Задача 1
// Дано число обозначающее день недели. 
// Выяснить является номер дня недели выходным

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