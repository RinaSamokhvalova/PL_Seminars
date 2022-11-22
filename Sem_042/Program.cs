// Семинар 6.
// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ConvertNumberBinary (int numberDec)
{
    string res = String.Empty;
    int temp;
    while (numberDec != 0)
    {
        temp = numberDec % 2;
        res = temp.ToString() + res;
        numberDec = numberDec / 2;
    }
    return res;
}

Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"В двоичной системме число имеет вид: {ConvertNumberBinary(number)}");
