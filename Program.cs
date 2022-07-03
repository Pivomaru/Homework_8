/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */ 
 

 /* void Print(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           Console.Write(arr[i, j] + " ");
       }
       Console.WriteLine();
   }

}
int m = 3, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
   for (int j = 0; j < mass.GetLength(1); j++)
   {
       mass[i, j] = new Random().Next(0, 10);
   }
}

Print(mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
         for (int k = 0; k < mass.GetLength(1) - 1; k++)
      {
        if (mass[i, k] < mass[i, k + 1])
        {
          int temp = mass[i, k + 1];
          mass[i, k + 1] = mass[i, k];
          mass[i, k] = temp;
        }
      }
    }
}
 Print(mass);   
    */ 

//////////////////////////////////////////////////////////////

   /* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.*/


/* void Print(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           Console.Write(arr[i, j] + " ");
       }
       Console.WriteLine();
   }

}
int m = 3, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
   for (int j = 0; j < mass.GetLength(1); j++)
   {
       mass[i, j] = new Random().Next(0, 10);
   }
}

Print(mass);
Console.WriteLine();

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int minSumLine = 0;
int sumLine = SumLineElements(mass, 0);   
     for (int i = 1; i < mass.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(mass, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой  элементов ({sumLine}) "); */

    /////////////////////////////////////////////////////


/// последующие задачи оказались для меня сложными. Не решил =(





