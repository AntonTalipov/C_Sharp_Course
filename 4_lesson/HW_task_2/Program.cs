/* Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("type a number");
int num1 = int.Parse(Console.ReadLine());
int Sum (int num)
{
    int count = num % 10;
while (num > 0)
{
  num = num / 10;
  count = count + (num % 10);  
}
return count;
}
Console.WriteLine(Sum(num1));