// Семинар 5.
// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
int numberN = int.Parse(Console.ReadLine() ?? "0");

int[] arrayN = new int[numberN];
FillArray(arrayN, -10, 10);
Console.Write ("Исходный массив: ");
PrintArray(arrayN);
Console.WriteLine ();

int length = arrayN.Length;
for (int index = 0; index < length; index++)
{
    arrayN[index] = arrayN[index] * (-1);
}

Console.Write ("Полученный массив: ");
PrintArray(arrayN);
Console.WriteLine ();