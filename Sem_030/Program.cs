// Семинар 4.
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//заполнить массив
void FillArray(int[] collection)
{
   int length = collection.Length;
   int index = 0;
   while (index < length)
   {
       collection[index] = new Random().Next(0, 2);
       index++;
   }
}

// Распечатать массив
void PrintArray(int[] col)
{
   int count = col.Length;
   int position = 0;
   while (position < count)
   {
       Console.Write ($"{col[position]} ");
       position++;
   }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine ();