// Семинар 5.
// Задача 31. Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

// Ищем сумму элементов в массиве. 0 - отрицательные, 1 - положительные
int SumElement (int[] array, int mark)
{
    int length = array.Length;
    int sum = 0;
    if (mark == 1)
    {
        for (int index = 0; index < length; index++)
        {
            if (array[index] > 0) sum = sum + array[index];
        }
    }
    else
    {
        for (int index = 0; index < length; index++)
        {
            if (array[index] < 0) sum = sum + array[index];
        }
    }
    return sum;
}

int[] arrayN = new int[12];
FillArray(arrayN, -9, 9);
Console.Write ("Полученный массив: ");
PrintArray(arrayN);
Console.WriteLine ();
Console.Write ($"Cумма положительных чисел равна {SumElement(arrayN, 1)}, сумма отрицательных равна {SumElement(arrayN, 0)}");