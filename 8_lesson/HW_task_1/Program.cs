/* Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива */

void FillArray(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix [i, j] = new Random().Next(1, 10);
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
void ChangeFromMaxToMin (int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int q = 0; q < matrix.GetLength(1)-j-1 ; q++)
        {
           if (matrix[i, q] < matrix [i, q+1])
           {
            (matrix[i, q], matrix [i, q+1]) = (matrix[i, q+1], matrix [i, q]);
           } 
        }
    }
}  
for (int o = 0; o < matrix.GetLength(0); o++)
{
    for (int u = 0; u < matrix.GetLength(1); u++)
    {
       Console.Write($"{matrix [o,u]} ");
    } 
    Console.WriteLine();
}
}
int [,] matrix = new int [5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeFromMaxToMin(matrix);

