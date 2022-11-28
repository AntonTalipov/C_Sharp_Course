/* Задача 1: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру этого
числа.
456 -> 5
782 -> 8
918 -> 1 */
Console.WriteLine("type a number");
int num1 = int.Parse(Console.ReadLine());
int Medium(int num)
{
    return num / 10;
}
int Medium1(int num)
{
    return num % 10;
}
//int num2=Medium(num1);
//Console.WriteLine(Medium1(num2));
Console.WriteLine(Medium1(Medium(num1)));
