// Семинар 7. Домашнее задание.
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetMatrix(int sizeM, int sizeN, int minValue, int maxValue)
{
    int[,] res = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintMatrix(int[,] matr) // Метод печатает двухмерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageColumns (int[,] matr)
{
    double[] res = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            res[j] = res[j] + Convert.ToDouble(matr[i,j]);
        }
        res[j] = res[j] / matr.GetLength(0);
        Console.Write($"{res[j]} ");
    }
    Console.WriteLine();
}

int[,] matrix = GetMatrix(2, 3, 0, 9);
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);
AverageColumns(matrix);