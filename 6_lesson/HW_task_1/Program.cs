/* Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.WriteLine("type a count of array");
int n = int.Parse(Console.ReadLine());
int [] arr = new int [n];
void Collection(int [] array)
{ 
    for (int i = 0; i < n; i++)
    {
      array[i]= new Random().Next(-100, 100);
    }
}
void Print(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	    Console.Write($"{arr[i]}, ");
	Console.WriteLine();
}
int SumPos (int [] arr){
    int sum = 0;
  for (int i = 0; i < arr.Length; i++)
  { 
    if (arr[i] > 0)
    {
        sum = sum + 1;
    }
  }  
  return sum;
}
Collection(arr);
Print(arr);
Console.WriteLine(SumPos(arr));