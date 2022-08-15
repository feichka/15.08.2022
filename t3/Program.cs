/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[n,m];
double sum = 0;
for (int i = 0; i <n; i++)
{
  for (int j = 0; j < m; j++)
    {
        array[i,j] = new Random().Next(1,10);
         Console.Write(array[i,j] + " ");
    }
   
         Console.WriteLine();
}

for (int i = 0; i<n; i++)
{
    sum = 0;
     for (int j = 0; j< m; j++)
    {
        
        sum+=array[j,i];
         
    }     
    Console.WriteLine("Среднее арифметическое " + sum/m);
}



     

       
         

