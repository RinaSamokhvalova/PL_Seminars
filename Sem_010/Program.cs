// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write ("Введите натуральное трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine (number > 99 & number < 1000);
//Console.WriteLine (number > -1000 & number < -99);

if ((number > 99 & number < 1000) | (number > -1000 & number < -99))
{
    number = number / 10;
    Console.WriteLine (number % 10);
}
else
{
    Console.WriteLine ("Вы сделали ошибку при вводе");
}