// Семинар 5.
// Задача 35. Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Метод задает и распечатывает одномерный массив
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.WriteLine("Сформированный массив:");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine();
    return res;
}


int[] array = GetArray(123, -1000, 1000);

int caunt = 0;
foreach (int el in array)
{
    if (el >= 10 && el <= 99) caunt++;
}
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {caunt}");