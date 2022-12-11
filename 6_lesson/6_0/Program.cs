/* Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

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
/* void TurnArray(int [] arr)
{
	for (int i = arr.Length-1; i >= 0; i--)
	    Console.Write($"{arr[i]}, ");
	Console.WriteLine();
}*/
void RevMas(int[] arr)
	{
	    int size = arr.Length;
	    for (int i = 0; i < size / 2; i++)
	        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);// заменить местами
	}
Collection(arr);
Print(arr);
RevMas(arr);
Print(arr);
