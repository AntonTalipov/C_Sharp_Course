/* Задайте двумерный массив. Найдите сумму элементов
главной диагонали.
Например, задан массив:
1 4 7
5 9 2
8 4 2
Сумма элементов главной диагонали: 1+9+2 = 12 */

void FillArray(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix [i, j] = new Random().Next(-10, 11);
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
void SumArrayDiagonale(int [,] matrix)
{
    int sum = 0;
 for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       if (i == j)
       {
        sum = sum + matrix [i,j];
       }
    } 
} 
Console.WriteLine($"summ of numbers general diagonale is {sum}");  
}
int [,] matrix = new int [4, 4];
FillArray(matrix);
PrintArray(matrix);
SumArrayDiagonale(matrix);