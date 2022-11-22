// Семинар 7. Домашнее задание.
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetMatrix(int sizeM, int sizeN, int minValue, int maxValue)
{
    double[,] res = new double[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            res[i, j] = new Random().NextDouble() * 100;
        }
    }
    return res;
}

void PrintMatrix(double[,] matr) // Метод печатает двухмерный массив
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

Console.WriteLine("Зададим матрицу размера M * N");
Console.Write("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

double[,] matrix = GetMatrix(rows, columns, 0, 10);
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);