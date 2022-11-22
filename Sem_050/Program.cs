// Семинар 7. Домашнее задание.
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

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

void CheckPosition(int[,] matr, int row_i, int column_j)
{
    if (row_i < 0 || row_i > matr.GetLength(0)-1 || column_j < 0 || column_j > matr.GetLength(1)-1)
    {
        Console.WriteLine("В данной матрице отсутствует такая позиция элемента");
    }
    else 
    {
        Console.WriteLine($"Элемент матрицы равен: {matr[row_i, column_j]}");
    }
}

int[,] matrix = GetMatrix(10, 10, 0, 9);
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);

Console.WriteLine("Зададим позицию элемента в двумерном массиве");
Console.Write($"Введите номер строки от 0 до {matrix.GetLength(0) - 1}: ");
int row = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Введите номер столбца от 0 до {matrix.GetLength(1) - 1}: ");
int column = int.Parse(Console.ReadLine() ?? "0");
CheckPosition(matrix, row, column);