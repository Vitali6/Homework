/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

void Massif(int[,] array)
{
    const int indent = 3;
    for (int line = 0; line < array.GetLength(0); line++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[line, column] = new Random().Next(1, 30);
            Console.Write($" {array[line, column],indent} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Sort(int[,] array)
{
    const int indent = 3;
    int line = 0;
    while (line < array.GetLength(0))
    {
        int column = 0;
        int[] arr = new int[4];
        for (int count = 0; count < arr.Length; count++)
        {
            arr[count] = array[line, column];
            column++;
        }
        Array.Sort(arr);

        column = 0;

        for (int count = 0; count < array.GetLength(1); count++)
        {
            array[line, count] = arr[column];
            column++;
            Console.Write($" {array[line, count],indent} ");
        }

        Console.WriteLine();
        line++;
    }
    Console.WriteLine();
}
int[,] arr = new int[4, 4];
Massif(arr);
Sort(arr);