// Семинар 8. 
// Задача 57. Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

void PrintMatrix2(int[,] matr) // распечатываем не весь массив, а только указанноу количество столбцов
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        Console.WriteLine($"{matr[0, i]} встречается {matr[1, i]} ");
    }
}

int[,] GetFrequencyArray (int[,] matr)
{
    int[,] tempfrequencyArray = new int[2, matr.GetLength(0) * matr.GetLength(1)];
    int caunt = 0;
    tempfrequencyArray[0, 0] = matr[0, 0];
    bool flag = false;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            flag = false;
            for (int k = 0; k < caunt + 1; k++)
            {

                if (matr[i, j] == tempfrequencyArray[0, k])
                {
                    tempfrequencyArray[1, k]++;
                    flag = true;
                }
            }
            if (flag == false)
            {
                caunt++;
                tempfrequencyArray[0, caunt] = matr[i, j];
                tempfrequencyArray[1, caunt] = 1;

            }
        }
    }
    int[,] newFrequencyArray = new int[2, caunt + 1];
    for (int i = 0; i < caunt + 1; i++)
    {
        newFrequencyArray[0, i] = tempfrequencyArray[0, i];
        newFrequencyArray[1, i] = tempfrequencyArray[1, i];
    }
    return newFrequencyArray;
}

Console.WriteLine("Зададим матрицу размера M * N");
Console.Write("Введите число строк M: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов N: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns, 0, 9);
Console.WriteLine("Сформированный массив:");
PrintMatrix(matrix);

int[,] frequencyArray = GetFrequencyArray (matrix);
Console.WriteLine("Частотный массив:");
PrintMatrix(frequencyArray);
PrintMatrix2(frequencyArray);