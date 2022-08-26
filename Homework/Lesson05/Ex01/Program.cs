/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}
void ClearArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 ==0) count++;                 
    }
    Console.Write($"Четных чисел в массиве = {count}");
}
Console.Clear();
Console.Write("Введите длинну массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[N];
FillArray(mass);
Console.WriteLine();
ClearArray(mass);