// Семинар 6. Домашнее задание.
// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -7, 567, 89, 223-> 3

int[] GetArrayConsole(int size)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write ("Введите число: ");
        res[i] = int.Parse(Console.ReadLine() ?? "0");
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

int CountElement (int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el > 0) count++;
    }
    return count;    
}

Console.Write ("Введите количество чисел: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int[] array = GetArrayConsole(number);
Console.Write ("В полученном массиве: ");
PrintArray(array);
int countPos = CountElement(array);
Console.WriteLine($"{countPos} чисел больше 0");