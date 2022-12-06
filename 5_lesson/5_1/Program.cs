/* Напишите программу замена элементов массива:
положительные элементы замените на соответствующие
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

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
void Change(int [] array){
    int neg = 0;
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] != 0)
       {
        array[i]=array[i] * (-1);
       } 
    }

}
Collection(arr);
PrintArray(arr);
Change(arr);
PrintArray(arr);





