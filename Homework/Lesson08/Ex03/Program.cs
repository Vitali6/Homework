/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void MassivThree(int[,,] threeMassiv)
{
    int number = new Random().Next(1, 90);
    int count = 0;

    for (int x = 0; x < threeMassiv.GetLength(0); x++)
    {
        for (int y = 0; y < threeMassiv.GetLength(1); y++)
        {
            for (int z = 0; z < threeMassiv.GetLength(2); z++)
            {
                threeMassiv[x, y, z] = number + count;
                count++;
            }

        }
    }
}

void PrintMassiv(int[,,] threeMassiv)
{
    for (int x = 0; x < threeMassiv.GetLength(0); x++)
    {
        for (int y = 0; y < threeMassiv.GetLength(1); y++)
        {
            for (int z = 0; z < threeMassiv.GetLength(2); z++)
            {
                Console.Write($" {threeMassiv[x, y, z]} [{x}, {y}, {z}] ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] newthreemass = new int[2, 2, 2];
MassivThree(newthreemass);
PrintMassiv(newthreemass);