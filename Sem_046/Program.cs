// Семинар 7.
// Задача 46. Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Метод задает и распечатывает двухмерный массив
int[,] GetMatrix(int sizeM, int sizeN, int minValue, int maxValue)
{
    int[,] res = new int [sizeM, sizeN];
    Console.WriteLine("Сформированный массив:");
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            res[i,j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{res[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return res;
}


Console.WriteLine("Зададим матрицу размера M * N");
Console.Write ("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns, 0, 100);