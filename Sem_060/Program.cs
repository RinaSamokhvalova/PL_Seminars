// Семинар 8. Домашнее задание.
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Зададим матрицу размера M * N * K");
Console.Write("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов K: ");
int pages = int.Parse(Console.ReadLine() ?? "0");

if (rows * columns * pages <= 90)
{
    int[,,] matrix3D = GetMatrix3DNonRecurring(rows, columns, pages);
    Console.WriteLine("Сформированный массив:");
    PrintMatrix3D(matrix3D);
}
else Console.WriteLine("Сформировать матрицу из неповторяющихся двузначных чисел с данными параметрами невозможно, умменьшите один из параметров ");

// Методы

int[,,] GetMatrix3D(int sizeM, int sizeN, int sizeK, int minValue, int maxValue)
{
    int[,,] res = new int[sizeM, sizeN, sizeK];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            for (int k = 0; k < sizeK; k++)
            {
                res[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return res;
}

int[,,] GetMatrix3DNonRecurring(int sizeM, int sizeN, int sizeK)
{
    int[,,] res = new int[sizeM, sizeN, sizeK];
    int[] tempVector = new int [sizeM * sizeN * sizeK];
    int temp = 0;
    tempVector[0] = new Random().Next(10, 100);
    int index = 1;
    bool flag = false ;
    while (index < tempVector.Length)
    {
        temp = new Random().Next(10, 100);
        flag = false ;
        for (int i = 0; i < index; i++)
        {
            if (tempVector[i] == temp) flag = true;
        }
        if (flag == false)
        {
            tempVector[index] = temp;
            index++;
        }
    }
    Console.WriteLine(String.Join(" ", tempVector)); // - вывод одномерного массива
    index = 0;    
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            for (int k = 0; k < sizeK; k++)
            {
                res[i, j, k] = tempVector[index];
                index++;
            }
        }
    }
    return res;
}

void PrintMatrix3D(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
        Console.WriteLine ($"Страница {k}:");
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"M[{i}, {j}, {k}] = {matr[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}