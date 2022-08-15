/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double[,]array = new double[n,m];
double x;
for (int i = 0; i <n; i++)
{
  for (int j = 0; j < m; j++)
    {
      x = new Random().NextDouble()*100;
        array[i,j] = Math.Round(x,2);

        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

     