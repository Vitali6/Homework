/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0 && y < 0)
{
    Console.WriteLine("Точка в плоскости 4");
}
else if (x>0 && y<0)
{
    Console.WriteLine("Точка в плоскости 3");
}

