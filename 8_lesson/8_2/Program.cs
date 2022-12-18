/* Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. Значения элементов массива 0..9 */

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
void PrintArr(int [] arr)
{
 for (int i = 0; i < arr.Length; i++)
 {
    Console.WriteLine($"{i} mmets: {arr[i]}");
 }
 Console.WriteLine();
}
int [] Dictionary(int [,] matrix)
{
    int [] dict = new int [10];
    foreach(int item in matrix)
    dict [item] += 1;
    return dict;
}
int [,] matrix = new int [4, 4];
FillArray(matrix);
PrintArray(matrix);
PrintArr(Dictionary(matrix));


