// Семинар 8. Домашнее задание.
// Задача 54. Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Зададим матрицу размера M * N");
Console.Write("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns, 0, 9);
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);
SortArray(matrix);
Console.WriteLine("отсортированный массив:");
PrintMatrix(matrix);

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

void SortArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i,j] < matr[i,k])
                {
                    int temp = matr[i,j];
                    matr[i,j] = matr[i,k];
                    matr[i,k] = temp;
                }
            }
        }
    }
}