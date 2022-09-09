/*for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    int pos = j;
    for (int k = j; k < matrix.GetLength(1); k++)
    {
      if (matrix[i, k] > matrix[i, pos]) pos = k;
    }
    (matrix[i, pos], matrix[i, j]) = (matrix[i, j], matrix[i, pos]);
  }
}
*/
/*// Написать программу, которая на вход получает массив данных от пользователя 
// через запятую и на выходе выдаёт массив состоящий из четных чисел

// Уточните условие

// пример:
// 1,2,3,4,5,6,7,8 => 2 4 6 8

// Разбить строку на составные части
// превратить набор строк в набор чисел
// сделать выборку по условию
// подготовить данные для вывода
*/
int Solve(int start, int end, int p, int m)
{
  int[] ways = new int[end + 1];
  ways[start] = 1;
  //if(start == 2) return 1;

  for (int i = start + 1; i <= end; i++)
  {
    if (i % m == 0)
    {
      ways[i] = ways[i - p] + ways[i / m];
    }
    else
    {
      ways[i] = ways[i - p];
    }
  }
  Console.WriteLine($"Str: {String.Join(' ', ways)}");

  return ways[end];
}

Console.WriteLine($"{Solve(2, 12, 1, 2)}");
