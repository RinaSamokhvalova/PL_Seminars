// Семинар 8. 
// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

void PrintMatrix(int[,] matr)
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

int[] SearchMinElementMatrix(int[,] matr)
{
    int[] min = new int[3];
    min[0] = matr[0, 0];
    min[1] = 0;
    min[2] = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min[0])
            {
                min[0] = matr[i, j];
                min[1] = i;
                min[2] = j;
            }
        }
    }
    return min;
}

int[,] ChangeMatrix(int[,] matr, int[] min)
{
    int[,] res = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(0); j++)
        {
            if (i < min[1] && j < min[2]) res[i, j] = matr[i, j];
            if (i < min[1] && j >= min[2]) res[i, j] = matr[i, j + 1];
            if (i >= min[1] && j < min[2]) res[i, j] = matr[i + 1, j];
            if (i >= min[1] && j >= min[2]) res[i, j] = matr[i + 1, j + 1];
        }
    }
    return res;
}

Console.WriteLine("Зададим матрицу размера M * N");
Console.Write("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns, 0, 9);
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);
int[] minElement = SearchMinElementMatrix(matrix);
Console.WriteLine($"Минимальный элемент равен {minElement[0]}, [{minElement[1]},{minElement[2]}]");
int[,] newmatrix = ChangeMatrix(matrix, minElement);
Console.WriteLine("Новый массив:");
PrintMatrix(newmatrix);