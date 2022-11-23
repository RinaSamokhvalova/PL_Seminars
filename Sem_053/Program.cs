// Семинар 8. 
// Задача 53. Задайте двумерный массив. 
// Напишите программу, которая меняет местами первую и последнюю строку массива.

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

void ChangePositionRows(int[,] matr) // меняет местами первую и последнюю строку массива.
{
    int temp = 0;
    int rowN = matr.GetLength(1) - 1;

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        temp = matr[0, j];
        matr[0, j] = matr[rowN, j];
        matr[rowN, j] = temp;
    }
}

Console.WriteLine("Зададим матрицу размера M * N");
Console.Write("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns, 0, 9);
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);

ChangePositionRows(matrix);
Console.WriteLine("Преобразованный массив:");
PrintMatrix(matrix);