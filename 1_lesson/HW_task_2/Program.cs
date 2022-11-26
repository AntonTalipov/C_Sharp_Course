//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Write a number1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number2: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number3: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1>num3)
{
    Console.Write($"max={num1} ");
}
else if (num2 > num1 && num2>num3)
{
    Console.Write($"max={num2} ");
}
else
{
   Console.Write($"max={num3} "); 
}