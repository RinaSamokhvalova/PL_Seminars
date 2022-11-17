// Семинар 5. Домашнее задание.
// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Метод задает и распечатывает одномерный массив
double[] GetArray(int size)
{
    double[] res = new double[size];
    Console.WriteLine("Сформированный массив:");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine ();
    return res;
}

double Difference(double[] arr)
{
    double res = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    res = max - min;
    return res;
}

Console.Write ("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
double[] array = GetArray(size);
double diff = Difference(array);

Console.WriteLine($"Разницу между максимальным и минимальным элементами массива: {diff}");