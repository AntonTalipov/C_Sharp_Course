 //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Write a number,which is more than 0: ");
int num = int.Parse(Console.ReadLine());
if (num>0)
{
    int num1=1;
    while (num1<=num)
    {
      if (num1%2==0)
      {
        Console.Write($"{num1}, "); 
      } 
      num1++;
    }
}
else
{
    Console.Write("This number is less than 0");
}