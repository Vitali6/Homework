/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

// Запрос точек отсчета у пользователя
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void Natural(int numberOne, int numberTwo)
{
    int sum;
    if (numberOne < numberTwo)
    {
        sum = numberOne - 1;
        while (numberOne <= numberTwo)
        {
            sum = sum + numberOne;
            numberOne++;
        }
        Console.Write($"Сумма чисел от M до N: {sum}");
    }
    else if (numberOne > numberTwo)
    {
        sum = numberTwo - 1;
        while (numberOne >= numberTwo)
        {
            sum = sum + numberTwo;
            numberTwo++;
        }
        Console.Write($"Сумма чисел от M до N: {sum} ");

    }
    else
    {
        sum = 0;
        Console.Write($"Сумма чисел от M до N: {sum} ");

    }
}

Natural(numberM, numberN);

