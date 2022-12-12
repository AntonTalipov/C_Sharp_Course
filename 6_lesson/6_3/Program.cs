/* Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

/*Console.WriteLine("type a number");
int num = int.Parse(Console.ReadLine());
string Fibo(int num)
{
int fib1 = 0;
int fib2 = 1;
string sum ="0 1";
while (num > 2)
{   int fibSum = fib1+fib2;
    sum = sum + $" {fibSum}";
    fib1 = fib2;
    fib2 = fibSum;
    num = num - 1;
}
return sum;
}
Console.WriteLine($"first {num} numbers in Fibo are {Fibo(num)}");*/
void Fibbonacci (int num)
	{
	    int a = 0, b = 1;
	
	    for (int i = 0; i < num; i++)
	    {
	        Console.Write($"{a} ");
	        (a, b) = (b, a+b);
	    }
	}
	
	int num = int.Parse(Console.ReadLine());
	Fibbonacci(num);