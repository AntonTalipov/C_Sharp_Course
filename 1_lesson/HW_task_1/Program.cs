//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Write a number1: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number2: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.Write($"max={num1} ");
}
else
{
   Console.Write($"max={num2} "); 
}