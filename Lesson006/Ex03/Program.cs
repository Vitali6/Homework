﻿int m = 3;
int n = 4;
double[,] arr = new double[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = (new Random().NextDouble()) * new Random().Next(-100, 100);
        System.Console.Write($"{arr[i, j]} " );
    }
    System.Console.WriteLine();
}
