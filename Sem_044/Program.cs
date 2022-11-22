// Семинар 6.
// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] GetArrayFibonacci (int size)
{
    int[] res = new int[size];
    res[0] = 0;
    res[1] = 1;

    for(int i = 2; i < size; i++)
    {
        res[i] = res[i - 2] + res[i - 1];
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

Console.Write ("Введите количество чисел фибоначи: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int[] array = GetArrayFibonacci(number);
Console.WriteLine("Полученные числа:");
PrintArray(array);




