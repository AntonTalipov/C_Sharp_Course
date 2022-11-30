/* Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.WriteLine("type number, which is more than 0");
int num1 = int.Parse(Console.ReadLine());
int num=1;
if (num1>0)
{
   while (num<=num1)
{
   Console.WriteLine(Math.Pow(num, 3));
   num++;
} 
}
else
{
    Console.WriteLine("Error! This number is less than 0");
}