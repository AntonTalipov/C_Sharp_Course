// 2 task
Console.WriteLine("Write a number1: ");

int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number2: ");

int num2 = int.Parse(Console.ReadLine());
int num3=num2*num2;
if(num3==num1)
{
    Console.WriteLine("Yes");
}
else
{
   Console.WriteLine("No"); 
}