/* Задайте двумерный массив. Введите элемент, и найдите
первое его вхождение, выведите позиции по горизонтали и
вертикали, или напишите, что такого элемента нет.
Например, такой массив:
1 4 7 2
5 9 2 3
8 4 2 4
Введенный элемент 2, результат: [1, 4]
Введенный элемент 6, результат: такого элемента нет. */

Console.WriteLine("type a number");
int num = int.Parse(Console.ReadLine());
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
string CheckNumberInArray(int [,] matrix, int num)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       if (matrix[i, j] == num)
       {
        return $"[{i},{j}]";
       }
    }    
}
return "no";
}
int [,] matrix = new int [4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine(CheckNumberInArray(matrix, num));
