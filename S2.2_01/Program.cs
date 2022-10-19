// Сесминар 2.2 - Задача 1
// Дано число. Проверить кратно ли оно 7 и 23

Console.Write ("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine()); - не актуальное 
int number = int.Parse(Console.ReadLine() ?? "0");

if ((number % 7 == 0) && (number % 23 == 0)) 
{
    Console.WriteLine ($"Число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine ($"Число {number} не кратно 7 и 23");
}