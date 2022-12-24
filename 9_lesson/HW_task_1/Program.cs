/*Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/
Console.WriteLine("type a number m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("type a number n");
int n = int.Parse(Console.ReadLine());
void Row(int m, int n)
	{
	    
	    if (m > n) return;
        if (m % 2 == 0)
        {
        Console.Write($" {m} ");
        }
	    Row(m+1, n);
	}
	
	Row(m,n);