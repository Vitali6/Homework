/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(a);
if (s.Length > 2)
{
    Console.WriteLine(s[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
