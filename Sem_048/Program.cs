// Семинар 7.
// Задача 48. Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int[,] GetMatrixSum(int sizeM, int sizeN) // Метод задает и распечатывает двухмерный массив
{
    int[,] res = new int [sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            res[i,j] = i + j;
        }
    }
    return res;
}

void PrintMatrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i + j;
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Зададим матрицу размера M * N");
Console.Write ("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrixSum(rows, columns);
Console.WriteLine("Сформированный массив:");
PrintMatrix (matrix);