/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

Console.WriteLine("type a count of array");
int n = int.Parse(Console.ReadLine());
int [] arr = new int [n];
void Collection(int [] array)
{ 
    for (int i = 0; i < n; i++)
    {
      array[i]= new Random().Next(0, 1000);
    }
}
int Check(int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 10 && array[i] < 100 )
       {
        count = count + 1;
       }
    }
     return count;
}
Collection(arr);
Console.WriteLine(Check(arr));
