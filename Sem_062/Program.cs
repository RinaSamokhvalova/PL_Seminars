// Семинар 8. Домашнее задание.
// Задача 62. Заполните спирально массив 4 на 4.

Console.Write("Введите размерность квадратной матрицы: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
int[] vec = GetVector(rows);
Console.WriteLine(String.Join(" ", vec));       // - вывод одномерного массива

int[,] matrix = GetMatrixSpiral(rows, vec);
Console.WriteLine("Сформированная матрица:");
PrintMatrix(matrix);

// Методы

int[] GetVector(int size)   // - формируем массив из количества проходов по квадратной матрице по спирали в зависимости от размера матрицы.
                            //(1) 1
                            //(2) 2 1 1
                            //(5) 5 4 4 3 3 2 2 1 

{
    int[] res = new int[2 * (size - 1) + 1];
    res [0] = size;
    int index = 1;
    for (int i = size - 1; i > 0; i = i - 1)
    {
        res[index] = i;
        res[index+1] = i;
        index = index + 2;
    }
    return res;
}

int[,] GetMatrixSpiral(int size, int[] vect)
{
    int[,] res = new int[size, size];
    int flag = 1;
    int index = 0;
    int indexi = 0;
    int indexj = -1;
    for (int i = 0; i < (size - 1) * 2 + 1; i++)
    {
        for (int j=0; j < vect[i]; j++)
        {
            if (flag == 1) 
            {
                indexj++;
                res[indexi,indexj] = index;
                index++;
                Console.WriteLine ($"[{indexi}, {indexj}] = {res[indexi, indexj]} ");
            }
            else 
            {
                if (flag == 2) 
                {
                    indexi++;
                    res[indexi,indexj] = index;
                    Console.WriteLine ($"[{indexi}, {indexj}] = {res[indexi, indexj]} ");
                    index++;
                }
                else 
                {
                    if (flag == 3) 
                    {
                        indexj = indexj - 1;
                        res[indexi,indexj] = index;
                        Console.WriteLine ($"[{indexi}, {indexj}] = {res[indexi, indexj]} ");
                        index++;
                    }
                    else
                    {
                        indexi = indexi - 1;
                        res[indexi,indexj] = index;
                        Console.WriteLine ($"[{indexi}, {indexj}] = {res[indexi, indexj]} ");
                        index++;
                        flag = 0;
                    }
                }
            }
        }
        flag++;
        Console.WriteLine ($"f = {flag}");
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