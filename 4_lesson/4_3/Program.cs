/* Напишите программу, которая выводит
массив из 8 элементов, заполненный нулями и
единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */
int n = int.Parse(Console.ReadLine());
int [] arr = new int [n];

void Collection(int [] array)
{
    for (int i = 0; i < n; i++)
    {
      array[i]= new Random().Next(0, 2);
      Console.Write(array[i]);
    }
}
Collection(arr);