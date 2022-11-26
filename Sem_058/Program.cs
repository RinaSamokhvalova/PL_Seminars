// Семинар 8. Домашнее задание.
// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Зададим матрицу A:");
Console.Write("Введите число строк M: ");
int rowsA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columnsA = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Зададим матрицу В:");
Console.Write("Введите число строк M: ");
int rowsB = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columnsB = int.Parse(Console.ReadLine() ?? "0");

int[,] matrixA = GetMatrix(rowsA, columnsA, 0, 9);
Console.WriteLine("Сформированная матрица А:");
PrintMatrix(matrixA);

int[,] matrixB = GetMatrix(rowsB, columnsB, 0, 9);
Console.WriteLine("Сформированная матрица B:");
PrintMatrix(matrixB);

// Произведение AB определено, если число столбцов матрицы A совпадает с числом строк матрицы B. 
// (Другими словами, число элементов в строке матрицы A должно совпадать с числом элементов в столбце матрицы B.) 
// Произведение BA определено, если число столбцов матрицы B совпадает с числом строк матрицы A.

if (columnsA == rowsB)
{
    int[,] matrixAB = ProductMatrix(matrixA, matrixB);
    PrintMatrix(matrixAB);
}
else Console.WriteLine("Эти матрицы нельзя умножить - они не согласованы");


// Методы

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

int[,] ProductMatrix(int[,] matrA, int[,] matrB)
{
    int[,] res = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            for (int k = 0; k < matrB.GetLength(0); k++)
            {
                res[i, j] = res[i, j] + matrA[i, k] * matrB[k, j];
            }
        }
    }
    return res;
}