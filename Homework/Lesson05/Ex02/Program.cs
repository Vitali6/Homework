/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void ClearArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 !=0) sum += arr[i];
    }
    Console.WriteLine(sum);
}
Console.Clear();
Console.WriteLine("Введите длинну массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[N];
FillArray(mass);
ClearArray(mass);