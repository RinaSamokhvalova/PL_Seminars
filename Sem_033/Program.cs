// Семинар 5.
// Задача 33. Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

//заполнить массив
void FillArray(int[] array, int min, int max)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(min, max + 1);
    }
}

// Распечатать массив
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        Console.Write ($"{array[index]} ");
    }
}

Console.Write ("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");

int[] arrayN = new int[size];
FillArray(arrayN, -10, 10);
Console.Write ("Исходный массив: ");
PrintArray(arrayN);
Console.WriteLine ();

Console.Write ("Введите число: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");

bool flag = false;
foreach (int i in arrayN)
{
    if (i == numberN) flag = true;
}
if (flag == true) 
{
    Console.Write ($"Исходный массив содержит число {numberN}");
}
else Console.Write ($"Исходный массив не содержит число {numberN}");
Console.WriteLine ();