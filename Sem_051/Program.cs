// // Семинар 7.
// Задача 51. Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

void SumMatrixElementDiag(int[,] matr) // Метод изменяет двухмерный массив
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + matr[i, i];
            }
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
}

Console.WriteLine("Зададим матрицу размера M * N");
Console.Write("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns, 0, 10);
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);
SumMatrixElementDiag(matrix);
