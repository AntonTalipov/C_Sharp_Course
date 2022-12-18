/* Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */

void FillArray(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix [i, j] = new Random().Next(0, 10);
    } 
}
}
void PrintArray(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       Console.Write($"{matrix [i,j]} ");
    } 
    Console.WriteLine();
}
}
void FindMin (int [,] matrix)
{ 
int row = 0;
int column = 0;
int min = matrix[row,column];

   for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i,j] < min)
      {
        min = matrix[i,j];
        row = i;
        column = j;
      } 
    } 
} 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == row || j == column)
      {
         continue;
      }
      else
      {
        Console.Write($"{matrix [i,j]} ");
      }
    } 
    Console.WriteLine();
}
}
int [,] matrix = new int [4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindMin(matrix);