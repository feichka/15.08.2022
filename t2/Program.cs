/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1,7 -> такого числа в массиве нет
*/

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[n,m];
for (int i = 0; i <n; i++)
{
    for (int j = 0; j < m; j++)
    {
    array[i,j] = new Random().Next(0,10);
    Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
 
for (int i = 0; i <n; i++)
   {
        for (int j = 0; j < m; j++)
            {
                Console.WriteLine("Введите строку ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите столбец ");
                int b = Convert.ToInt32(Console.ReadLine());
                {
                    if (a<n || b <m)
                    {
                        array[i,j] = array[(a-1),(b-1)];
                        Console.WriteLine("Ваше число " + array[i,j]); 
                    }
                    else
                    Console.WriteLine("Такого элемента нет");
                }
        return;
            }
            
}