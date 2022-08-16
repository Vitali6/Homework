/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int n = 1;

while (n <= a)
{
    Console.WriteLine(Math.Pow(n, 3));
    n++;
} 

