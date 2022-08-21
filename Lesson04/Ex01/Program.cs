/* 1. Напишите метод, которая возвращает массив из N элементов, заполненный нулями и единицами в случайном порядке.
N = 3 => [1, 0, 0]
N = 8 => [1,0,1,1,0,1,0,0]

2. написать метод, который принимает на вход
двоичное представление числа в виде массива ARR и выдаёт десятичное представление
ARR = [1, 0, 0] => 4
ARR = [1,0,1,1,0,1,0,0] => 180
3. написать метод, который принимает на вход
десятичное представление числа N и показатель основания СС P, в котороую
нужно перевести это число
N = 31, P = 2 => 11111
N = 31, P = 8 => 37
ДОГОВОРИМСЯ, что  2<= p <= 9*/

int N = 8;
int[] Method1(int N) 
{
    int[] arr = new int [N];
    for (int i = 0; i <= N - 1; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

 int[] arr = Method1(N);
int[] а = {1,0,0};
//           0 1 2   
int result = 0;

for (int i = 0; i < N; i++) // 
{
    if (i <= 2) result = result + ((arr[i]*2) + arr[i+1]);
    else result = result + (arr[i]*2);
}

Console.WriteLine(result);
