// Семинар 8. 
// Задача 55. Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void RotationMatrix (int[,] matr) // меняет местами первую и последнюю строку массива.
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            temp = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = temp;
        }
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

if (rows == columns)
{
    RotationMatrix(matrix);
    Console.WriteLine("Преобразованный массив:");
    PrintMatrix(matrix);
}
else Console.WriteLine("Матрица не квадратная, ее нельзя перевернуть");