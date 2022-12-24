/*Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */
Console.WriteLine("type a number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("type a number b");
int b = int.Parse(Console.ReadLine());
int Summ (int a, int b)
	{
         if (b == 0) 
        {
            return 1;
        }
	    return Summ (a, b-1) * a;
	}
Console.WriteLine(Summ(a, b));