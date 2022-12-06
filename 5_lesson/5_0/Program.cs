/* Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.*/

Console.WriteLine("type a count of array");
int n = int.Parse(Console.ReadLine());
int [] arr = new int [n];
void Collection(int [] array)
{ 
    for (int i = 0; i < n; i++)
    {
      array[i]= new Random().Next(-9, 10);
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
void Count(int [] array){
    int neg = 0;
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] < 0)
       {
        neg = neg + array[i];
       } 
       else if (array[i] > 0)
       {
        pos = pos + array[i];
       }
    }
    Console.WriteLine($"Summ of negative {neg}");
    Console.WriteLine($"Summ of positive {pos}");
}
Collection(arr);
PrintArray(arr);
Count(arr);



