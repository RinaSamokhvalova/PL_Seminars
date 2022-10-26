// Задача 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number  = new Random().Next(100, 1000); 
Console.WriteLine ($"Исходное число: {number}");

int digit1 = number % 10;
int digit3 = number / 100;
int result = digit3 * 10 + digit1;

Console.WriteLine ($"Полученое число: {result}");
