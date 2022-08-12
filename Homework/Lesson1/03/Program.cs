/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

int a = 4;
int b = -3;
int c = 7;
if (a % 2 ==0)
{
    Console.WriteLine(a + " " + "Да");
}    
else
{
    Console.WriteLine("Нет");
}
if (b % 2 ==0)
{
    Console.WriteLine(b + "Да");
}
else
{
    Console.WriteLine("Нет");
}
if (c % 2 ==0)
{
    Console.WriteLine(c + "Да");
}
else
{
    Console.WriteLine("Нет");
}