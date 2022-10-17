// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
// Другое решение задачи

string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.Write ("Введите число от 1 до 7: ");
//int number = int.Parse(Console.ReadLine());
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine("Вы ввели число, которое не удовлетворяет заданным условиям");
}
else
{
    if (number > 7)
    {
        Console.WriteLine("Вы ввели число, которое не удовлетворяет заданным условиям");
    }
    else
    {
       Console.WriteLine(array[number - 1]);
    }
}