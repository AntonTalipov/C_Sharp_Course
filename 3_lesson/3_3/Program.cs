/* Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */
Console.WriteLine("type number");
int num1 = int.Parse(Console.ReadLine());
int num=1;
if (num1>0)
{
   while (num<=num1)
{
   Console.WriteLine(Math.Pow(num, 2));
   num++;
} 
}
else
{
    Console.WriteLine("error");
}