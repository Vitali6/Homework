/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Clear();

double[] newarray = new double[20];
void FillArray(double[]collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble() , 2);
        Console.Write($"{collection[i]}; ");
    }
    Console.WriteLine();
}
void Different(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine(max - min);
} 
Console.Clear();
Console.WriteLine("Введите длинну массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] mass = new double[N];
FillArray(mass);
Console.WriteLine("Разница между max и min: ");
Different(mass);