/*Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30*/
Console.WriteLine("type a number m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("type a number n");
int n = int.Parse(Console.ReadLine());
int Row(int m, int n)
	{
	    if( m > n ) 
        {
            return 0;
        }
	    return Row (m + 1, n) + m;
	}
	
Console.WriteLine(Row(m, n));