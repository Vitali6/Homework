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
}
FillArray(newarray);