/* Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 67] -> 0 */

Console.WriteLine("type a count of array");
int n = int.Parse(Console.ReadLine());
int [] arr = new int [n];
void Collection(int [] array)
{ 
    for (int i = 0; i < n; i++)
    {
      array[i]= new Random().Next(1, 100);
    }
}
void Print(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	    Console.Write($"{arr[i]}, ");
	Console.WriteLine();
}
void CountArray(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( i % 2 == 0)
        {
          sum = sum + arr[i];  
        }
    }
    Console.WriteLine( $"sum of elements of odd positions is {sum}");
}
Collection(arr);
Print(arr);
CountArray(arr);
