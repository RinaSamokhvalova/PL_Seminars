// Семинар 4. Домашняя работа 
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.(в примере показаны два разных массива, создаем именно для 8 элементов)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//заполнить массив
void FillArray(int[] array, int min, int max)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(min, max);
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
int dim = int.Parse(Console.ReadLine() ?? "0");
int[] arrayN = new int[dim];
Console.Write ("Введите нижний диапазон значений массива: ");
int minBorder = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите нижний диапазон значений массива: ");
int maxBorder = int.Parse(Console.ReadLine() ?? "0");
FillArray(arrayN, minBorder, maxBorder);
Console.Write ("Полученный массив: ");
PrintArray(arrayN);
Console.WriteLine ();