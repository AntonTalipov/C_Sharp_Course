/* Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3, 7, 22, 2, 78] -> 76 */

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
void CountDifArray(int [] arr)
{
    int max=arr[0];
    int min=arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if ( arr[i] > max)
        {
          max = arr[i];  
        }
        else if ( arr[i] < min)
        {
          min = arr[i];  
        }
    }
     int dif=max-min;
    Console.WriteLine( $"the difference between the max={max} and min={min} number is {dif}");
}
Collection(arr);
Print(arr);
CountDifArray(arr);
