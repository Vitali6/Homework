/*Напишите функцию замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int [] arr = new int [] {-4, -8, 8, 2};

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = arr[i] * -1;
}
string str = string.Empty;
for (int i = 0; i < arr.Length; i++)
{
    str = str + Convert.ToString(arr[i]) + ", ";

}
Console.Write(str);