/*
Задана целочисленная матрица, состоящая из N строк и M столбцов. 
Требуется транспонировать ее относительно горизонтали.
*/

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[n,m];
for (int i = 0; i <n; i++)
{
  for (int j = 0; j < m; j++)
    {
        array[i,j] = new Random().Next(1,10);
         Console.Write(array[i,j] + " ");
    }
   
         Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Новый массив");
Console.WriteLine();

for (int i = 0; i <n; i++)
{
  for (int j = 0; j < m; j++)
  {
    if (i<+n/2)
    {
   int temp = array[i,j];
   array[i,j] = array[n-i-1,j];
   array[n-i-1,j] = temp;
    }
    else
  array[i,j] = array[i,j];
  Console.Write(array[i,j] + " ");
  }  
  Console.WriteLine();
  
}
    