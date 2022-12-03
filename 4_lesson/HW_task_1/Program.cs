/* Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.*/
Console.WriteLine("type a number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("type an extent");
int num2 = int.Parse(Console.ReadLine());
int Sum (int a, int b)
{
int result = 1;
for (int i = 0; i < b; i++)
{
  result = result * a;
}
return result;
}
Console.WriteLine(Sum(num1, num2));