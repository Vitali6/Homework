/*Задача 33: Задайте массив. Напишите функцию, которая определяет, присутствует ли заданное число в массиве.
решать без встроенных функций
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

bool CheckElement(int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (value == arr[i])
        {
             return true;
        }
    }

    return false;
}
int[] arr = { 6, 7, 19, 345, 3 };
int value = 4;

bool f = CheckElement(arr, value);

System.Console.WriteLine(f);
