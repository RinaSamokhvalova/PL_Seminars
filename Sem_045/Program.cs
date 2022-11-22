// Семинар 6.
// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] arr)
{
    int[] res = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        res[i] = arr[i];
    }
    return res;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i <arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Console.Write ("Введите размерность массива: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int[] array = GetArray(number, 0, 100);
Console.WriteLine("Полученный массив: ");
PrintArray(array);
int[] newarray = CopyArray(array);
Console.WriteLine("Скопированный массив: ");
PrintArray(newarray);

