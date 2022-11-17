// Семинар 5. Домашнее задание.
// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOddElements(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        res = res+arr[i];
    }
    return res;
}

Console.Write ("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = GetArray(size, 0, 100);
int sum = SumOddElements(array);

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");