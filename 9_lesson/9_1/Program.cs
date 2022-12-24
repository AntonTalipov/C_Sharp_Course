/*Задайте значения M и N. Напишите программу, которая
рекурсивно выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8*/
/*Console.WriteLine("type a number1");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("type a number2");
int n = int.Parse(Console.ReadLine());
void Row (int m, int n)
{ 
    if (m < n)
    {
        if (n-1 == m)
        {
            return;
        }
    Row (n-1, m);
    Console.Write($" {n} ");
    }
    else 
    {
        Row (m-1, n);
    Console.Write($" {m} ");
}}
Row(m,n);*/
void Numbers(int m, int n)
	{
	    
	    if (m > n) return;
	    
	    Console.Write($" {m} ");
	    Numbers(m+1, n);
	}
	
	Numbers(5,8);