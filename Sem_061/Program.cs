// Семинар 8. Домашнее задание.
// Задача 61. Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

Console.Write("Вевдите количество строк треугольника Паскаля: ");
int numberLines = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[numberLines, numberLines];
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);

GetMatrixPascalTriangle(matrix);
Console.WriteLine("Сформированная матрица паскаля:");
PrintMatrix(matrix);
Console.WriteLine("Сформированный треугольник паскаля:");
PrintPascalTriangle(matrix);



// Методы
void GetMatrixPascalTriangle(int[,] matr)
{
    matr[0, 0] = 1;
    matr[1, 0] = 1;
    matr[1, 1] = 1;
    for (int i = 2; i < matr.GetLength(0); i++)
    {
        matr[i, 0] = 1;
        for (int j = 1; j <= i; j++)
        {
            matr[i, j] = matr[i - 1, j - 1] + matr[i - 1, j];
        }
    }
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

void PrintPascalTriangle(int[,] matr)
{
    int max = matr[matr.GetLength(0) - 1, matr.GetLength(0) / 2];
    Console.WriteLine($"Максимальный элемент - {max}, его размерность {CounterDigit(max)}:");
    string line = string.Empty;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < (((matr.GetLength(0) - i) * CounterDigit(max)) + matr.GetLength(0) - i - 1) / 2; j++)
        {
            line = line + " ";
        }
        for (int j = 0; j < i + 1; j++)
        {
            line = line + matr[i, j].ToString();
            for (int k = CounterDigit(matr[i, j]); k < CounterDigit(max) + 1; k++)
            {
                line = line + " ";
            }
        }
        Console.WriteLine(line);
        line = string.Empty;
    }
}

int CounterDigit(int number)
{
    int counter = 0;
    while (number > 0)
    {
        counter++;
        number = number / 10;
    }
    return counter;
}