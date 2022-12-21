/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
void FillArray(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix [i, j] = new Random().Next(1, 5);
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
void NewArr( int [,] arr1, int [,] arr2)
{
    int [,] arr = new int [arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr[i,j] = arr1[i,j] * arr2[i,j];
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
       Console.Write($"{arr [i,j]} ");
    } 
    Console.WriteLine();
}
}
int [,] matrix1 = new int [2, 2];
int [,] matrix2 = new int [2, 2];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
NewArr(matrix1, matrix2);