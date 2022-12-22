/*Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N при помощи рекурсии.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */
Console.WriteLine("type a number");
int n = int.Parse(Console.ReadLine());
void Row (int n)
{
    if (n==0)
    {
        return;
    }
    Row (n-1);
    Console.Write($" {n} ");
}
Row(n);
