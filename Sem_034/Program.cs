// Семинар 5. Домашнее задание.
// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
    Console.WriteLine ();
    return res;
}

int CountEvenNumbers(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) res++;
    }
    Console.WriteLine ();
    return res;
}

Console.Write ("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = GetArray(size, 100, 999);
int count = CountEvenNumbers(array);

Console.WriteLine($"Количество чётных чисел в массиве: {count}");