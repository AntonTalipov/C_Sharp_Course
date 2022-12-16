/*Задайте двумерный массив. Найдите элементы, у которых
обе позиции чётные, и замените эти элементы на их квадраты.*/

void FillArray(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix [i, j] = new Random().Next(-9, 10);
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
void ChangeArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       if (i%2!=0 && j%2!=0)
       {
        matrix [i, j] =  Convert.ToInt32(Math.Pow(matrix [i, j], 2));;
       }
    } 
}
}
int [,] matrix = new int [3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeArray(matrix);
PrintArray(matrix);