/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с
 наименьшей суммой элементов: 1 строка*/
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
void MinRow ( int [,] matrix)
{   int m = matrix.GetLength(0);
    int sum = 0; 
    int [] arr = new int [m];  
 for (int i = 0; i < matrix.GetLength(0); i++)
{   
    sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {  
       sum = sum + matrix[i,j];
    } 
    arr [i] = sum;
    Console.WriteLine($"{i+1} row sum is {sum}");
}  
int min = arr[0];
int t = 1;
for (int i = 1; i < arr.Length; i++)
{  
   if (arr[i] < min)
   {
    min = arr[i];
    t = i+1;
   } 
}
Console.WriteLine($"row with min sum is {t}");
}
int [,] matrix = new int [4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinRow(matrix);


