/* Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

Console.WriteLine("type a count of array");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("type a number");
int num = int.Parse(Console.ReadLine());
int [] arr = new int [n];
void Collection(int [] array)
{ 
    for (int i = 0; i < n; i++)
    {
      array[i]= new Random().Next(1, 6);
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
string Check(int [] array){
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] == num)
       {
        return "Your number is in array";
       }
    }
    return "Your number isn`t in array";
}
Collection(arr);
PrintArray(arr);
Console.WriteLine(Check(arr));






