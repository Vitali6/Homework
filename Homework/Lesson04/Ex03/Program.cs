/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int [] arr = new int [8];
int n = arr.Length;
for (int i = 0; i < n; i++)
{
    arr[i] = new Random().Next();
    Console.Write($"{arr[i]} ");
}
    