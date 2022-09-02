int[] Arr;

int count;
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


static void NewMethod(out int[] Arr, out int count)
{
    int Rand = new Random().Next(2, 8);
    Console.WriteLine($"Введите {Rand} чисел");
    Arr = new int[Rand];
    count = 0;
    for (int i = 0; i < Rand; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        Arr[i] = Convert.ToInt32(Console.ReadLine());
        if (Arr[i] > 0) count++;
    }
}
NewMethod(out Arr, out count);

Console.WriteLine(string.Join(", ", Arr));
Console.WriteLine($"Количество чисел больше нуля: {count}");