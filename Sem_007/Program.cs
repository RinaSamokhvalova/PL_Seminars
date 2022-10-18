// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write ("Введите натуральное трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine (number > 99 & number < 1000);
//Console.WriteLine (number > -1000 & number < -99);

if ((number > 99 & number < 1000) | (number > -1000 & number < -99))
{
    Console.WriteLine (number % 10);
}
else
{
    Console.WriteLine ("Вы сделали ошибку при вводе");
}