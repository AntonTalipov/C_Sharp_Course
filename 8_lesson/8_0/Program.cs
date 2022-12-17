/* Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

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
       Console.Write($"{matrix [i,j]}  ");
    } 
    Console.WriteLine();
}
}
void ChangeRow ( int [,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == 0)
        {
          Console.Write($"{matrix[matrix.GetLength(0)-1, j]}  ");
        }
        else if (i == (matrix.GetLength(0)-1))
        {
          Console.Write($"{matrix[0, j]}  ");  
        }
        else
        {
            Console.Write($"{matrix [i,j]}  "); 
        }
    } 
    Console.WriteLine();
}
}
int [,] matrix = new int [4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeRow(matrix);

