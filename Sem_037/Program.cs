// Семинар 5.
// Задача 37. Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] GetArrayProd(int size, int[] arr)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = arr[i] * arr[arr.Length - 1 - i];
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine ();
    return res;
}

Console.Write ("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = GetArray(size, 0, 10);

int length;
if (array.Length % 2 == 0)
{
    length = array.Length / 2;
}
else length = array.Length / 2 + 1;
Console.WriteLine($"Длинна нового массива: {length}");

Console.WriteLine("Новый массив:");
int[] arrayRes = GetArrayProd(length, array);

Console.WriteLine ();
