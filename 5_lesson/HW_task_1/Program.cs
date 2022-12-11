/* Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("type a count of array");
int n = int.Parse(Console.ReadLine());
int [] arr = new int [n];
void Collection(int [] array)
{ 
    for (int i = 0; i < n; i++)
    {
      array[i]= new Random().Next(100, 1000);
    }
}
void Print(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	    Console.Write($"{arr[i]}, ");
	Console.WriteLine();
}
void CheckArray(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( arr[i] % 2 == 0)
        {
          sum = sum +1;  
        }
    }
    Console.WriteLine( $"Number of even is {sum}");
}
Collection(arr);
Print(arr);
CheckArray(arr);
