/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void FillMatrix(double[,] matrix)                                            
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int mult = new Random().Next(-100, 100);
            matrix[i, j] = Math.Round(new Random().NextDouble() * mult, 2);
        }
    }
}

void PrintMatrix(double[,] matrix)                                              
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}], ");
        }
        Console.WriteLine();
    }
}

int m = new Random().Next(2, 11);
int n = new Random().Next(2, 11);
double[,] numbers = new double[m, n];
FillMatrix(numbers);
PrintMatrix(numbers);