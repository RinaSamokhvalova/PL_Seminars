// Семинар 7.
// Задача 49. Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void СhangeMatrix(int[,] matr) // Метод изменяет двухмерный массив
{
    for (int i = 0; i < matr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < matr.GetLength(1); j = j + 2)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matr[i, j] = matr[i, j] * matr[i, j];
            }
        }
    }
}

Console.WriteLine("Зададим матрицу размера M * N");
Console.Write("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns, 0, 10);
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);
СhangeMatrix(matrix);
Console.WriteLine("Преобразованный массив:");
PrintMatrix(matrix);