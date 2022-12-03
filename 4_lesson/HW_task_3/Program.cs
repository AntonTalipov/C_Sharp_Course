/* Напишите программу, которая задаёт массив из
8 элементов случайными числами и выводит их на экран.
Оформите заполнение массива и вывод в виде функции
(пригодится в следующих задачах)
1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8
6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1 */

Console.WriteLine("type a count of array");
int n = int.Parse(Console.ReadLine());
int [] array1 = new int [n];

void Collection(int [] array)
{
    for (int i = 0; i < n; i++)
    {
      array[i]= new Random().Next(1, 35);
    }
}
void PrintArray(int [] array) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write( $"{array[i]}, ");
    }
    Console.WriteLine();
}
Collection(array1);
PrintArray(array1);