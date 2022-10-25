// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int counter = 0;
int digit = 0;
int temp;

if (number > 0)
{
    temp = number;
}
else temp = number * (-1);

while (temp > 100)
{
    counter++;
    digit = temp % 10;
    temp = temp / 10;
}

if (counter == 0)
{
    Console.WriteLine ("Третья цифра отсутствует");
}
else 
    {
        
        Console.WriteLine ($"Третья цифра числа {number} равна {digit}");
    }